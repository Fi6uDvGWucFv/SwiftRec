namespace Captura.Windows
{
    public class WindowsSettings : PropertyStore
    {
        public bool UseGdi
        {
            get => Get(true);
            set => Set(value);
        }
    }
}