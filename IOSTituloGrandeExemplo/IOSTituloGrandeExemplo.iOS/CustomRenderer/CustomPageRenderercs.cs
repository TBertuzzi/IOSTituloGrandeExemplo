using IOSTituloGrandeExemplo.Controles;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace IOSTituloGrandeExemplo.iOS
{
    public class CustomPageRenderer : PageRenderer
    {
        //Quando a View Aparecer verifica a propriedade e marca as preferencias para titulos grandes
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            var exibirTituloGrande = TituloGrande.GetExibirTituloGrande(Element);

            //Apenas Devices com IOS 11
            if (UIDevice.CurrentDevice.CheckSystemVersion(11, 0) && NavigationController != null && NavigationController.NavigationBar != null)
            {
                NavigationController.NavigationBar.PrefersLargeTitles = exibirTituloGrande;
            }
        }

        //Quando a View Desaparecer marca as preferencias para não exibir titulos grandes
        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);

            //Apenas Devices com IOS 11
            if (UIDevice.CurrentDevice.CheckSystemVersion(11, 0) && NavigationController != null && NavigationController.NavigationBar != null)
            {
                NavigationController.NavigationBar.PrefersLargeTitles = false;
            }
        }
    }
}
