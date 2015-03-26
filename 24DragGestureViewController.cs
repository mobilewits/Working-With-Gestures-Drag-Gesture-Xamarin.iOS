using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace DragGesture
{
	public partial class _4DragGestureViewController : UIViewController
	{


		UIRotationGestureRecognizer rotateGesture;
		UIPanGestureRecognizer panGesture;
		UIImageView imageView


		public _4DragGestureViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();


			float r = 0;
			float dx = 0;
			float dy = 0;


			using (var image = UIImage.FromFile ("img/Finger.png")) {
				img_view = new UIImageView (image){Frame = new RectangleF (new PointF(0,0), image.Size)};
				img_view.UserInteractionEnabled = true;
				View.AddSubview (img_view);
			}


			rotateGesture = new UIRotationGestureRecognizer ((rg) => {
				if ((rg.State == UIGestureRecognizerState.Began || rg.State == UIGestureRecognizerState.Changed) && (rg.NumberOfTouches == 2)) {

					img_view.Transform = CGAffineTransform.MakeRotation (rg.Rotation + r);
					img_view.Transform=  
				} else if (rg.State == UIGestureRecognizerState.Ended) {
					r += rg.Rotation;
				}
			});


			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

