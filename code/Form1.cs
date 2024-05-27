namespace Calculator
{
    public partial class Form1 : Form
    {
        public class Memento
        {
            public double Result { get; private set; }
            public string Operation { get; private set; }

            public Memento(double result, string operation)
            {
                Result = result;
                Operation = operation;
            }
        }

        public class Caretaker
        {
            private Stack<Memento> mementos = new Stack<Memento>();

            public void SaveState(Memento memento)
            {
                mementos.Push(memento);
            }

            public Memento RestoreState()
            {
                if (mementos.Count > 0)
                {
                    return mementos.Pop();
                }
                else
                {
                    return null;
                }
            }
        }

        Double results = 0;
        String operation = "";
        bool enterValue = false;

        public Form1()
        {
            InitializeComponent();
        }

        //IOriginator
        public Memento CreateMemento()
        {
            return new Memento(results, operation);
        }

        public void SetMemento(Memento memento)
        {
            results = memento.Result;
            operation = memento.Operation;
            textBoxResult.Text = results.ToString();
            lblShopOp.Text = operation;
        }

        private Caretaker caretaker = new Caretaker();

        private void btnSave_Click(object sender, EventArgs e)
        {
            caretaker.SaveState(CreateMemento());
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Memento memento = caretaker.RestoreState();
            if (memento != null)
            {
                SetMemento(memento);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (enterValue))
            {
                textBoxResult.Text = "";
            }

            enterValue = false;
            Button num = (Button)sender;
            if (num.Text == ",")
            {
                if (!textBoxResult.Text.Contains(","))
                {
                    if (string.IsNullOrEmpty(textBoxResult.Text) || textBoxResult.Text == "0")
                    {
                        textBoxResult.Text = "0,";
                    }
                    else
                    {
                        textBoxResult.Text += num.Text;
                    }
                }
            }
            else
            {
                textBoxResult.Text += num.Text;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Length > 0)
            {
                string newText = textBoxResult.Text.Remove(textBoxResult.Text.Length - 1, 1);
                textBoxResult.Text = newText;
            }

            if (textBoxResult.Text == "")
            {
                textBoxResult.Text = "0";
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            try
            {
                results = Double.Parse(textBoxResult.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат числа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxResult.Text = "0";
                operation = "";
                enterValue = false;
            }
            textBoxResult.Text = "";
            lblShopOp.Text = System.Convert.ToString(results) + " " + operation;
            enterValue = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            lblShopOp.Text = "";
            try
            {
                switch (operation)
                {
                    case "+":
                        results += Double.Parse(textBoxResult.Text);
                        break;
                    case "-":
                        results -= Double.Parse(textBoxResult.Text);
                        break;
                    case "*":
                        results *= Double.Parse(textBoxResult.Text);
                        break;
                    case "/":
                        if (Double.Parse(textBoxResult.Text) == 0)
                        {
                            throw new DivideByZeroException("Деление на ноль недопустимо.");
                        }
                        results /= Double.Parse(textBoxResult.Text);
                        break;
                    case "Mod":
                        results %= Double.Parse(textBoxResult.Text);
                        break;
                }
                textBoxResult.Text = results.ToString();
                operation = "";
                enterValue = false;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxResult.Text = "0";
                operation = "";
                enterValue = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.D0:
                case Keys.D1:
                case Keys.D2:
                case Keys.D3:
                case Keys.D4:
                case Keys.D5:
                case Keys.D6:
                case Keys.D7:
                case Keys.D8:
                case Keys.D9:
                    if ((textBoxResult.Text == "0") || (enterValue))
                    {
                        textBoxResult.Text = "";
                    }
                    int num = keyData - Keys.D0;
                    textBoxResult.Text += num.ToString();
                    return true;
                case Keys.OemPeriod:
                case Keys.Decimal:
                    if (!textBoxResult.Text.Contains(","))
                    {
                        textBoxResult.Text += ",";
                    }
                    return true;
                case Keys.Add:
                    operator_Click(btnPlus, EventArgs.Empty);
                    return true;
                case Keys.Subtract:
                    operator_Click(btnMinus, EventArgs.Empty);
                    return true;
                case Keys.Multiply:
                    operator_Click(btnMultiplication, EventArgs.Empty);
                    return true;
                case Keys.Divide:
                    operator_Click(btnDivision, EventArgs.Empty);
                    return true;
                case Keys.Back:
                    btnDelete_Click(null, EventArgs.Empty);
                    return true;
                case Keys.Enter:
                    btnEquals_Click(null, EventArgs.Empty);
                    return true;
                case Keys.Escape:
                    btnCE_Click(null, EventArgs.Empty);
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}
