
using System;

using Foundation;
using UIKit;
using ObjCRuntime;

namespace CircleGraph.iOS
{
	public partial class Circle : UIViewController
	{
		public Circle () : base ("Circle", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			int _bigCircleLineWidth = 20;
			int _smallCircleLineWidth = 10;


			DashboardGraphView _graphView = new DashboardGraphView (mainCircleView1.Bounds, _bigCircleLineWidth, 0.8f);
			DashboardGraphView _MgraphView = new DashboardGraphView (mainCircleView1.Bounds, _bigCircleLineWidth, 0.8f);

			DashboardGraphView _graphView1 = new DashboardGraphView (circle1.Bounds, _smallCircleLineWidth, 0.6f);
			DashboardGraphView _graphView2 = new DashboardGraphView (circle1.Bounds, _smallCircleLineWidth, 0.6f);
			DashboardGraphView _graphView3 = new DashboardGraphView (circle1.Bounds, _smallCircleLineWidth, 0.6f);

			DashboardGraphView _graphView4 = new DashboardGraphView (circle1.Bounds, _smallCircleLineWidth, 0.6f);
			DashboardGraphView _graphView5 = new DashboardGraphView (circle1.Bounds, _smallCircleLineWidth, 0.6f);
			DashboardGraphView _graphView6 = new DashboardGraphView (circle1.Bounds, _smallCircleLineWidth, 0.6f);

			mainCircleView.AddSubview (_graphView);
			mainCircleView1.AddSubview (_MgraphView);

			circle1.AddSubview (_graphView1);
			circle2.AddSubview (_graphView2);
			circle3.AddSubview (_graphView3);
			circle4.AddSubview (_graphView4);
			circle5.AddSubview (_graphView5);
			circle6.AddSubview (_graphView6);


			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

