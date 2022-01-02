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
            Properties.Settings.Default.A = model.get_a();
            Properties.Settings.Default.B = model.get_b();
            Properties.Settings.Default.C = model.get_c();
            Properties.Settings.Default.Save();
        }
        private void update_from_model(object sender, EventArgs e)
        { // обновляем все поля на форме
            if (model.get_a() != -1)
            {
                tbA.Text = model.get_a().ToString();
                nudA.Value = model.get_a();
                trbrA.Value = model.get_a();
            }
            else
            {
                tbA.Text = "";
                nudA.ResetText();
                trbrA.Value = 0;
            }

            if (model.get_b() != -1)
            {
                tbB.Text = model.get_b().ToString();
                nudB.Value = model.get_b();
                trbrB.Value = model.get_b();
            } else
            {
                tbB.Text = "";
                nudB.ResetText();
                trbrB.Value = 0;
            }

            if (model.get_c() != -1)
            {
                tbC.Text = model.get_c().ToString();
                nudC.Value = model.get_c();
                trbrC.Value = model.get_c();
            }
            else
            {
                tbC.Text = "";
                nudC.ResetText();
                trbrC.Value = 0;
            }
        }
        private void check_tb(TextBox tb) // проверяем последовательность символов, введенных пользователем
        {
            if (tb.Text == "" || (tb.Text.Length == 1 && !Char.IsDigit(tb.Text[0])))
                // если строка пуста или введен 1 символ-не цифра, то очищаем строку
                tb.Text = "";
            else {
                int number = 0;
                //"Записываем" в number все цифры из строки tb
                if (tb.Text.Length > 0 && Char.IsDigit(tb.Text[0]))
                    number = int.Parse(tb.Text[0].ToString());
                if (tb.Text.Length > 1 && Char.IsDigit(tb.Text[1]))
                    number = number * 10 + int.Parse(tb.Text[1].ToString());
                if (tb.Text.Length > 2 && Char.IsDigit(tb.Text[2]))
                    number = number * 10 + int.Parse(tb.Text[2].ToString());
                if (tb.Text.Length > 3 && Char.IsDigit(tb.Text[3]))
                    number = number * 10 + int.Parse(tb.Text[3].ToString());
                // Проверка: число <= 100
                if (number > 100)
                    number = number / 10;
                // полученное число записывем в tb
                tb.Text = number.ToString();
            }
        }
        private void check_tb(NumericUpDown nud)
        {
            string str = nud.Value.ToString();
            if (str == "" || (str.Length == 1 && !Char.IsDigit(str[0])))
                // если строка пуста или введен 1 символ-не цифра, то очищаем строку
                nud.Value = 0;
                //nud.ResetText();
            else
            {
                int number = 0;
                // "Записываем" в number все цифры из строки nud
                if (str.Length > 0 && Char.IsDigit(str[0]))
                    number = int.Parse(str[0].ToString());
                if (str.Length > 1 && Char.IsDigit(str[1]))
                    number = number * 10 + int.Parse(str[1].ToString());
                if (str.Length > 2 && Char.IsDigit(str[2]))
                    number = number * 10 + int.Parse(str[2].ToString());
                if (str.Length > 3 && Char.IsDigit(str[3]))
                    number = number * 10 + int.Parse(str[3].ToString());
                // Проверка: число <= 100
                if (number > 100)
                    number = number / 10;
                // полученное число записывем в nud
                nud.Value = number;
            }
        }
        private void check_tb(TrackBar trbr)
        {
            string str = trbr.Value.ToString();
            if (str == "" || (str.Length == 1 && !Char.IsDigit(str[0])))
                // если строка пуста или введен 1 символ-не цифра, то очищаем строку
                trbr.Value = 0;
            else
            {
                int number = 0;
                // "Записываем" в number все цифры из строки trbr
                if (str.Length > 0 && Char.IsDigit(str[0]))
                    number = int.Parse(str[0].ToString());
                if (str.Length > 1 && Char.IsDigit(str[1]))
                    number = number * 10 + int.Parse(str[1].ToString());
                if (str.Length > 2 && Char.IsDigit(str[2]))
                    number = number * 10 + int.Parse(str[2].ToString());
                if (str.Length > 3 && Char.IsDigit(str[3]))
                    number = number * 10 + int.Parse(str[3].ToString());
                // Проверка: число <= 100
                if (number > 100)
                    number = number / 10;
                // полученное число записывем в trBr
                trbr.Value = number;
            }
        }
        //private void tb_KeyPress(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        TextBox tb = (TextBox)sender;
        //        char abc = tb.Name.ToString()[2];
        //        check_tb(tb);
        //        if (tb.Text == "")
        //            model.set_value(-1, abc);
        //        else
        //            model.set_value(Int32.Parse(tb.Text), abc);
        //    }
        //}
        private void tb_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            char abc = tb.Name.ToString()[2]; // узнаем с a,b или c мы работаем 
            check_tb(tb); // удаляем ненужные символы из поля и проверяем: число<=100
            if (tb.Text == "")
                model.set_value(-1, abc);
            else
                model.set_value(Int32.Parse(tb.Text), abc);
        }
        private void nud_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            char abc = nud.Name.ToString()[3]; // узнаем с a,b или c мы работаем
            check_tb(nud);
            if (nud.Value.ToString() == "")
                model.set_value(-1, abc);
            else
                model.set_value(Decimal.ToInt32(nud.Value),abc);
        }
        private void nud_KeyUp(object sender, KeyEventArgs e) 
        {   // при изменении значения не через кнопки "больше-меньше", искусственно вызываем valueChanged
            nud_ValueChanged(sender, e);
        }
        private void trbr_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trbr = (TrackBar)sender;
            char abc = trbr.Name.ToString()[4]; // узнаем с a,b или c мы работаем
            check_tb(trbr);
            if (trbrA.Value.ToString() == "")
                model.set_value(-1, abc);
            else
                model.set_value(trbr.Value, abc);
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
        public int get_a()
        {
            return a;
        }
        public int get_b()
        {
            return b;
        }
        public int get_c()
        {
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
        public void set_value_a(int a)
        {
            //if (a > 100)
            //    a = 100;
            this.a = a;
            check_b();
            observers.Invoke(this, null); //notify everyone who was subscribed
        }
        public void set_value_c(int c)
        {
            //if (c > 100)
            //    c = 100;
            this.c = c;
            check_b();
            observers.Invoke(this, null);
        }
        public void set_value_b(int new_b)
        {
            //if (b > 100)
            //    b = 100;
            if (new_b >= a && new_b <= c)
                b = new_b;
            observers.Invoke(this, null);
        }
        public void set_value(int new_num, char abc)
        { // меняем значение для свойста abc (a/b/c) 
            //if (new_num > 100)
            //    new_num = 100;
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
