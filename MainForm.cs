/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/7/2024
 * Time: 11:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace circlesdrawsignal
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public bool runningison = false;
		void MainFormLoad(object sender, EventArgs e)
		{
			g = this.panel1.CreateGraphics();
		}
		public Graphics g;
		
		public Pen p = new Pen(Color.FromArgb(255,0,0,0),1);
		public Brush b = new SolidBrush(Color.Black);
		public double rad = 180/Math.PI;
		
		public void draw(int L, int T, float rx, float ry, float startangle, int dimx, int dimy)
		{
			
			 
					 
			 
			 
			 
			 double  x = L*(Math.Cos(0/rad))+rx;
			 double  y = T*(Math.Sin(0/rad))+ry;
			 
			 double px = x;
			 double py = y;
			
			 
			 for(float i = startangle ; i<360+startangle+10; i+=10)
			 {
			 	
			 	//g.Clear(Color.White);
			 	
			 	x = L*(Math.Cos(i/rad))+rx;
			 	y = T*(Math.Sin(i/rad))+ry;
			 
			 	//g.DrawLine(p,(float)x,(float)y,(float)px,(float)py);
			 	if(i==startangle)
			 	 {
			 		 g.DrawEllipse(p,(float)x-dimx/2,(float)y-dimy/2,dimx,dimy);
			 		 //g.DrawEllipse(p,(float)(rx-L),(float)(ry-T),(float)(L*2),(float)(T*2));
			 	}
			 	//g.DrawLine(p,(float)rx,(float)ry,(float)(px),(float)(py));
			 	//g.DrawLine(p,(float)x,(float)y,(float)rx,(float)ry);
			 	
			 	px = x;
			 	py = y;
			 	
			 	//Thread.Sleep(1);
			 }
			 runningison=false;
			 button1.Enabled = true;
		}
		public void runh12()
		{
			if(runningison == false){
				float dim = 360/12;
			 for(float i = 0.0f ; i<360+dim; i+=dim)
			 {
			 	runningison = true;
			 	button1.Enabled=false;
			 
			 	//w,h,x,y
			 	draw(250,250,300,300,(int)(i),50,50);
			
				//g.Clear(Color.White);
				
			
			 }
			}
		}
		public void runm()
		{
			if(runningison == false){
				float dim = 360/60;
			 for(float i = 0.0f ; i<360+dim; i+=dim)
			 {
			 	runningison = true;
			 	button1.Enabled=false;
			 
			 	//w,h,x,y
			 	draw(250,250,300,300,(int)(i),2,2);
			
				//g.Clear(Color.White);
				
			
			 }
			}
		}
		public void runs()
		{
			if(runningison == false){
				float dim = 360/360;
			 for(float i = 0.0f ; i<360+dim; i+=dim)
			 {
			 	runningison = true;
			 	button1.Enabled=false;
			 
			 	//w,h,x,y
			 	draw(250,250,300,300,(int)(i),1,1);
			
				//g.Clear(Color.White);
				
			
			 }
			}
		}
		public void runh24()
		{
			if(runningison == false){
				float dim = 360/24;
			 for(float i = 0.0f ; i<360+dim; i+=dim)
			 {
			 	runningison = true;
			 	button1.Enabled=false;
			 
			 	//w,h,x,y
			 	draw(250,250,300,300,(int)(i),30,30);
			
				//g.Clear(Color.White);
				
			
			 }
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			runh12();
			runh24();
			runm();
			runs();
		}
	}
}
