using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;
using System.Windows.Controls;
using System.Windows;

namespace proj1 {

    public class Classroom {

        private string _className;
        private int _count;
        private WrapPanel _wrapPanel;

        public Classroom(string className, int count, FrameworkElement root) {
            _className = className;
            _count = count;
            _wrapPanel = (WrapPanel)root.FindName("classDisplay");
        }

        public void create() {

            StackPanel stackPanel = new StackPanel();
            stackPanel.Style = (Style)Application.Current.FindResource("classroom");

            if ((_count - 1) % 3 == 0) {
                if (_count < 4) {
                    stackPanel.Margin = new Thickness(0, 20, 0, 0);
                } else {
                    stackPanel.Margin = new Thickness(0, 30, 0, 0);
                }
            } else {
                if (_count < 4) {
                    stackPanel.Margin = new Thickness(70, 20, 0, 0);
                } else {
                    stackPanel.Margin = new Thickness(70, 30, 0, 0);
                }
            }

            Label label = new Label();
            label.Style = (Style)Application.Current.FindResource("classLabel");
            label.Content = _className;
            label.HorizontalContentAlignment = HorizontalAlignment.Center;
            label.Height = 40;

            Image image = new Image();
            image.Style = (Style)Application.Current.FindResource("classImage");

            Button button = new Button();
            button.Style = (Style)Application.Current.FindResource("enterButton");

            stackPanel.Children.Add(label);
            stackPanel.Children.Add(image);
            stackPanel.Children.Add(button);

            _wrapPanel.Children.Add(stackPanel);
        }
    }
}
