﻿/*
 * Created by SharpDevelop.
 * 
The MIT License (MIT)

Copyright (c) 2015 Ondrej Mikulec
o.mikulec@seznam.cz
Vsetin, Czech Republic

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
 */
using System;
using System.Collections.Generic;

namespace CatiaLubeGroove
{
	/// <summary>
	/// Description of DebugCreateAll.
	/// </summary>
	public static class DebugCreateAll
	{
		public static void createAll(List<myObdelnik> myObdelniksList, MECMOD.Sketch oSketch, INFITF.Application catiaInstance)
		{
			 MECMOD.Factory2D oFactory2D = oSketch.OpenEdition();
			 double count = 0;
 			foreach (myObdelnik obl in myObdelniksList) {
            
            	MECMOD.Line2D oLine2D1 =  oFactory2D.CreateLine(obl.P1x,obl.P1y,obl.P2x,obl.P1y);
            	MECMOD.Line2D oLine2D2 =  oFactory2D.CreateLine(obl.P2x,obl.P1y,obl.P2x,obl.P2y);
            	MECMOD.Line2D oLine2D3 =  oFactory2D.CreateLine(obl.P2x,obl.P2y,obl.P1x,obl.P2y);
            	MECMOD.Line2D oLine2D4 =  oFactory2D.CreateLine(obl.P1x,obl.P2y,obl.P1x,obl.P1y);
				
            	catiaInstance.set_StatusBar(Math.Round(count/myObdelniksList.Count*100) + "%");
            	
            	count++;
 			}
			 
			 oSketch.CloseEdition();
			
		}
	}
}