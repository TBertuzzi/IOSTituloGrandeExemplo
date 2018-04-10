using Xamarin.Forms;

namespace IOSTituloGrandeExemplo.Controles
{
    public class TituloGrande
    {
        public static readonly BindableProperty ExibirTituloGrandeProperty =
            BindableProperty.CreateAttached("ExibirTituloGrande", typeof(bool), typeof(TituloGrande), false);

        public static bool GetExibirTituloGrande(BindableObject view)
        {
            return (bool)view.GetValue(ExibirTituloGrandeProperty);
        }

        public static void SetExibirTituloGrande(BindableObject view, bool value)
        {
            view.SetValue(ExibirTituloGrandeProperty, value);
        }
    }
}
