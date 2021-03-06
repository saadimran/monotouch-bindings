using System;
using MonoTouch.UIKit;
using Datatrans;

namespace DatatransSample
{
	public class UserPaymentContoller : DtPaymentControllerDelegate
	{
		private readonly UINavigationController _rootNavigation;
		internal UINavigationController RootNavigation {
			get { return _rootNavigation; }
		}
		
		public UserPaymentContoller(UINavigationController nav ) {
			_rootNavigation = nav;
		}
		
		#region implemented abstract members of Datatrans.DtPaymentControllerDelegate
		public override void DidSucceed (DtPaymentController controller, DtPaymentRequest request)
		{
			Console.WriteLine("DidSucceed:");
			RootNavigation.PopToRootViewController(true);
			
		}

		public override void DidFail (DtPaymentController controller, MonoTouch.Foundation.NSError error)
		{
			Console.WriteLine("DidFail:");
			RootNavigation.PopToRootViewController(true);
		}

		#endregion
				
		public override void DidCancel (DtPaymentController controller, DtPaymentCancellationType cancellationType)
		{
			RootNavigation.PopToRootViewController(true);
		}
		
		
		// public override bool ShouldAutorotate (DtPaymentController controller, MonoTouch.UIKit.UIInterfaceOrientation toInterfaceOrientation)
		// {
		// 	return toInterfaceOrientation == MonoTouch.UIKit.UIInterfaceOrientation.Portrait;
		// }
	}
}

