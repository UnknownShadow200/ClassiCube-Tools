﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ModelPreviewer {
	
	public sealed class RawPart {
		public string Name, XAnim = "", YAnim = "", ZAnim = "";
		public int X1, Y1, Z1, X2, Y2, Z2;
		public int RotX, RotY, RotZ, TexX, TexY;
		public bool AlphaTest, Rotated, Wireframe, AxisLines = true;
	}
	
	public static class ModelFormat {
		
		static string[] Split(string value) {
			return value.Split(new char[] { ' ' }, 3);
		}
		
		static int[] SplitXYZ(string value) {
			string[] xyz = Split(value);
			return new int[] { int.Parse(xyz[0]), int.Parse(xyz[1]), int.Parse(xyz[2]) };
		}
		
		public static List<RawPart> Import(Stream stream) {
			StreamReader r = new StreamReader(stream);
			string line;
			List<RawPart> parts = new List<RawPart>();
			
			while ((line = r.ReadLine()) != null) {
				line = line.Trim();
				if (line.Length == 0 || line[0] == '#') continue;
				string[] bits = Split(line);
				
				int i = int.Parse(bits[0]);
				if (i >= parts.Count) parts.Add(new RawPart());
				RawPart part = parts[i];
				
				string type = bits[1].ToLower(), value = bits[2];
				if (type == "name") {
					part.Name = value;
				} else if (type == "xanim") {
					part.XAnim = value;
				} else if (type == "yanim") {
					part.YAnim = value;
				} else if (type == "zanim") {
					part.ZAnim = value;
				} else if (type == "p1") {
					int[] xyz = SplitXYZ(value);
					part.X1 = xyz[0]; part.Y1 = xyz[1]; part.Z1 = xyz[2];
				} else if (type == "p2") {
					int[] xyz = SplitXYZ(value);
					part.X2 = xyz[0]; part.Y2 = xyz[1]; part.Z2 = xyz[2];
				} else if (type == "rot") {
					int[] xyz = SplitXYZ(value);
					part.RotX = xyz[0]; part.RotY = xyz[1]; part.RotZ = xyz[2];
				} else if (type == "tex") {
					string[] xy = Split(value);
					part.TexX = int.Parse(xy[0]); part.TexY = int.Parse(xy[1]);
				} else if (type == "alpha") {
					part.AlphaTest = bool.Parse(value);
				} else if (type == "rotated") {
					part.Rotated = bool.Parse(value);
				}
			}
			return parts;
		}
		
		public static void Export(List<RawPart> parts, Stream stream) {
			StreamWriter w = new StreamWriter(stream);
			w.WriteLine("# ClassicalSharp raw model");
			
			for (int i = 0; i < parts.Count; i++) {
				RawPart p = parts[i];
				w.WriteLine(i + " name " + p.Name);
				w.WriteLine(i + " p1 " + p.X1 + " " + p.Y1 + " " + p.Z1);
				w.WriteLine(i + " p2 " + p.X2 + " " + p.Y2 + " " + p.Z2);
				w.WriteLine(i + " rot " + p.RotX + " " + p.RotY + " " + p.RotZ);
				w.WriteLine(i + " tex " + p.TexX + " " + p.TexY);
				w.WriteLine(i + " alpha " + p.AlphaTest);
				w.WriteLine(i + " rotated " + p.Rotated);
				if (p.XAnim != "") w.WriteLine(i + " xanim " + p.XAnim);
				if (p.YAnim != "") w.WriteLine(i + " yanim " + p.YAnim);
				if (p.ZAnim != "") w.WriteLine(i + " zanim " + p.ZAnim);
				w.WriteLine();
			}
			w.Close();
		}
		
		public static void ExportCode(List<RawPart> parts, Stream stream) {
			StreamWriter w = new StreamWriter(stream);
			w.WriteLine("// Skeleton implementation exported from ModelPreviewer");
			w.WriteLine("// You still need to implement rest of IModel yourself");
			w.WriteLine("// I recommend you press Ctrl + I in your IDE to format this");
			
			w.WriteLine("using System;");
			w.WriteLine("using ClassicalSharp");
			w.WriteLine("using ClassicalSharp.Entities;");
			w.WriteLine("using ClassicalSharp.Model;");
			w.WriteLine("using ClassicalSharp.Physics;");
			w.WriteLine("using OpenTK;");
			
			w.WriteLine();
			w.WriteLine("namespace MyModels {");
			w.WriteLine("\tpublic class MyModel : IModel {");
			w.WriteLine();
			w.WriteLine("\t\tpublic MyModel(Game window) : base(window) { }");
			w.WriteLine();
			
			w.WriteLine("\t\tpublic override void CreateParts() {");
			w.WriteLine("\t\t\tvertices = new ModelVertex[boxVertices * " + parts.Count + "];");
			
			foreach (RawPart part in parts) {
				w.Write("\t\t\t" + part.Name + " = ");
				if (part.Rotated) {
					w.Write("BuildRotatedBox(MakeRotatedBoxBounds(");
				} else {
					w.Write("BuildBox(MakeBoxBounds(");
				}
				
				w.Write(part.X1 + ", " + part.Y1 + ", " + part.Z1 + ", ");
				w.Write(part.X2 + ", " + part.Y2 + ", " + part.Z2 + ")");
				w.WriteLine();
				
				w.WriteLine(".TexOrigin(" + part.TexX + ", " + part.TexY + ")");
				w.WriteLine(".RotOrigin(" + part.RotX + ", " + part.RotY + ", " + part.RotZ + "));");
			}
			w.WriteLine("\t\t}");
			
			w.WriteLine();
			w.WriteLine("\t\tpublic override void DrawModel(Entity p) {");
			w.WriteLine("\t\t\tgame.Graphics.BindTexture(GetTexture(p));");
			w.WriteLine();
			
			bool alphaTest = true;
			foreach (RawPart part in parts) {
				if (part.AlphaTest != alphaTest) {
					w.WriteLine("\t\t\tgame.Graphics.AlphaTest = " + (part.AlphaTest ? "true;" : "false;"));
					alphaTest = part.AlphaTest;
				}
				
				if (part.XAnim == "" && part.YAnim == "" && part.ZAnim == "") {
					w.WriteLine("\t\t\tDrawPart(" + part.Name + ");");
				} else {
					w.WriteLine("\t\t\tDrawRotate(" + ModelAnim.Format(part.XAnim) + ", " 
					            + ModelAnim.Format(part.YAnim) + ", " + ModelAnim.Format(part.ZAnim) + ", "
					            + part.Name + ", " + (part.Name.ToLower() == "head" ? "true" : "false") + ")");
				}
			}
			
			w.WriteLine("\t\t\tUpdateVB()");
			if (!alphaTest) w.WriteLine("\t\t\tgame.Graphics.AlphaTest = true;");
			w.WriteLine("\t\t}");
			
			w.WriteLine("\t}");
			w.WriteLine("}");
			w.Flush();
		}
		
		public const string HumanoidRaw = @"
0 name Head
0 p1 -4 24 -4
0 p2 4 32 4
0 tex 0 0
0 rot 0 24 0
0 xanim -Pitch

1 name Torso
1 p1 -4 12 -2
1 p2 4 24 2
1 tex 16 16

2 name LeftLeg
2 p1 0 0 -2
2 p2 -4 12 2
2 tex 0 16
2 rot 0 12 0
2 xanim LeftLegX

3 name RightLeg
3 p1 0 0 -2
3 p2 4 12 2
3 tex 0 16
3 rot 0 12 0
3 xanim RightLegX

4 name LeftArm
4 p1 -4 12 -2
4 p2 -8 24 2
4 tex 40 16
4 rot -6 22 0
4 xanim LeftArmX
4 zanim LeftArmZ

5 name RightArm
5 p1 4 12 -2
5 p2 8 24 2
5 tex 40 16
5 rot 6 22 0
5 xanim RightArmX
5 zanim RightArmZ
		";
	}
}
