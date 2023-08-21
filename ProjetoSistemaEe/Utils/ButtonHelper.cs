using System.Drawing;
using System.Windows.Forms;

namespace ProjetoSistemaEe.Utils
{
    internal class ButtonHelper
    {
        public static void ChangeButtonBackground(Button button)
        {
            button.BackgroundImage = RecursosVisuais.button;
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        public static void ChangeButtonBackgroundImageOnHover(Button button)
        {
            button.BackgroundImage = RecursosVisuais.button_hover;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        public static void ChangeButtonBackgroundImageOnLeave(Button button)
        {
            button.BackgroundImage = RecursosVisuais.button;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        public static void ChangeButtonBackgroundImageOnMouseDown(Button button)
        {
            button.BackgroundImage = RecursosVisuais.button_clicked;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
    }
}