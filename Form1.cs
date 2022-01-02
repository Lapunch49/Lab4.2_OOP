using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4._2
{
    public partial class frmMain : Form
    {
        Model model;
        public frmMain()
        {
            InitializeComponent();
            // создаем model с сохраненными ранее значениями a,b,c
            model = new Model(Properties.Settings.Default.A, Properties.Settings.Default.B, Properties.Settings.Default.C);
            model.observers += new System.EventHandler(this.update_from_model);
            update_from_model(this, null); // искусственно вызвываем функцию для заполнения полей на форме
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {   // при закрытии формы запоминаем последние значения a,b,c 
            base.OnFormClosing(e);
            Properties.Settings.Default.A = model.get_num('a');
            Properties.Settings.Default.B = model.get_num('b');
            Properties.Settings.Default.C = model.get_num('c');
            Properties.Settings.Default.Save();
        }
        private void update_from_model(object sender, EventArgs e)
        {   // обновляем все поля на форме
            char abc = 'a';
            TextBox tb = tbA;
            NumericUpDown nud = nudA;
            TrackBar trbr = trbrA;
            while (abc != 'd')
            {
                if (model.get_num(abc) != -1)
                {
                    tb.Text = model.get_num(abc).ToString();
                    nud.Value = Decimal.ToInt32(model.get_num(abc));
                    trbr.Value = model.get_num(abc);
                    // дополнительно вручную вызываем функцию, фиксирующую изменение value для nudB
                    //if (abc == 'b' && nudB.Value == 0)
                    //{
                    //    EventArgs ee = new EventArgs ();
                    //    trbr_ValueChanged(trbrB, ee);
                    //}
                }
                else
                {
                    tb.Text = "";
                    nud.ResetText();
                    trbr.Value = 0;
                }
                abc++; // ?
                if (abc == 'b')
                {
                    tb = tbB;
                    nud = nudB;
                    trbr = trbrB;
                }
                else if (abc == 'c')
                {
                    tb = tbC;
                    nud = nudC;
                    trbr = trbrC;
                }
            }
        }
        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // чтобы при нажатии на enter не возникал звук
                TextBox tb = (TextBox)sender;
                char abc = tb.Name.ToString()[2];
                model.set_value(tb.Text.ToString(), abc);
            }
        }
        private void nud_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            char abc = nud.Name.ToString()[3]; // узнаем с a,b или c мы работаем
            model.set_value(nud.Value.ToString(),abc);
        }
        private void nud_KeyDown(object sender, KeyEventArgs e) 
        {   // при изменении значения не через кнопки "больше-меньше", искусственно вызываем valueChanged
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // чтобы при нажатии на enter не возникал звук
                nud_ValueChanged(sender, e);
            }
        }
        private void trbr_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trbr = (TrackBar)sender;
            char abc = trbr.Name.ToString()[4]; // узнаем с a,b или c мы работаем
            model.set_value(trbr.Value.ToString(), abc);
        }
    }
    public class Model
    {
        private
        int a=-1;
        int b=-1;
        int c=-1;
        public System.EventHandler observers; // для обновления всех полей при изменении a,b,c
        public Model(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int get_num(char abc) // вернуть свойство, совпадающее с символом abc(a/b/c)
        {
            if (abc == 'a')
                return a;
            else if (abc == 'b')
                return b;
            else 
                return c;
        }
        public void check_b() // проверка на корректность b при изменении a и c
        {
            if (b >= a && b <= c)
                return;
            // если условие не выполняется, b изменяется
            else if (b < a && a <= c)
                b = a;
            else if (b > c && c >= a)
                b = c;
            else
                b = -1;
        }
        public void set_value(string str, char abc)
        {
            // проверка входящей последовательности символов 
            // "Записываем" в new_num все цифры из строки str
            int new_num = 0;
            for (int i=0; i<str.Length; i=i+1)
            {
                if (Char.IsDigit(str[i]))
                    new_num = new_num * 10 + int.Parse(str[i].ToString());
            }
            //если получившееся число больше 100
            while (new_num > 100)
                new_num = new_num / 10;
            // или просто присваиваем значение 100
            //if (new_num > 100)
            //    new_num = 100;

            // если входящая строка была пустой, принимаем число как -1
            if (str == "") new_num = -1;

            // меняем значение для свойста abc (a/b/c) 
            if (abc == 'A')
                this.a = new_num;
            else if (abc == 'C')
                this.c = new_num;
            else if (abc == 'B' && new_num >= a && new_num <= c)
                this.b = new_num;
            // после изменения, проверяем выполнение условия a<=b<=c, если надо - меняем b
            check_b(); 
            // обновляем значения в полях формы
            observers.Invoke(this, null);
        }
    }
}
