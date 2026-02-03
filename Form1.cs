using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Lab07
{
    public partial class Form1 : Form
    {
        private ArrayList items = new ArrayList();

        public Form1()
        {
            InitializeComponent();

            InitGrid();
            BindEvents();

            SetStatus("Готово");
            UpdateButtonsEnabled();
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            BtnAdd_Click(sender, e);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            BtnUpdate_Click(sender, e);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            BtnDelete_Click(sender, e);
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            BtnClear_Click(sender, e);
        }

        // =========================
        // Привязка событий
        // =========================
        private void BindEvents()
        {
            // Кнопки
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;

            // Меню "Коллекция"
            mnuCreate.Click += MnuCreate_Click;
            mnuView.Click += MnuView_Click;
            mnuEdit.Click += MnuEdit_Click;
            mnuSave.Click += MnuSave_Click;
            mnuLoad.Click += MnuLoad_Click;
            mnuExit.Click += MnuExit_Click;

            // Меню "Работа"
            mnuSortAsc.Click += MnuSortAsc_Click;
            mnuSearchNearestToAverage.Click += MnuSearchNearestToAverage_Click;
            mnuTaskRangeNewCollection.Click += MnuTaskRangeNewCollection_Click;

            // О программе
            mnuAbout.Click += MnuAbout_Click;

            // Таблица
            dgvRationals.SelectionChanged += DgvRationals_SelectionChanged;
            dgvRationals.CellDoubleClick += DgvRationals_CellDoubleClick;
        }

        // =========================
        // Класс Rational (вариант 11)
        // =========================
        public sealed class Rational : IComparable
        {
            public int Numerator { get; private set; }
            public int Denominator { get; private set; }

            public Rational(int numerator, int denominator)
            {
                if (denominator == 0)
                    throw new ArgumentException("Знаменатель не может быть равен 0.");

                // знаменатель всегда положительный
                if (denominator < 0)
                {
                    numerator = -numerator;
                    denominator = -denominator;
                }

                int g = Gcd(Math.Abs(numerator), denominator);
                Numerator = numerator / g;
                Denominator = denominator / g;
            }

            public double ToDouble()
            {
                return (double)Numerator / Denominator;
            }

            public override string ToString()
            {
                return Numerator + "/" + Denominator;
            }

            public int CompareTo(object obj)
            {
                if (obj == null) return 1;

                Rational other = obj as Rational;
                if (other == null)
                    throw new ArgumentException("Неверный тип для сравнения.");

                // a/b ? c/d => a*d ? c*b
                long left = (long)Numerator * other.Denominator;
                long right = (long)other.Numerator * Denominator;

                if (left < right) return -1;
                if (left > right) return 1;
                return 0;
            }

            public static bool TryParse(string numText, string denText, out Rational r, out string error)
            {
                r = null;
                error = null;

                int n, d;

                if (!int.TryParse((numText ?? "").Trim(), out n))
                {
                    error = "Числитель должен быть целым числом.";
                    return false;
                }

                if (!int.TryParse((denText ?? "").Trim(), out d))
                {
                    error = "Знаменатель должен быть целым числом.";
                    return false;
                }

                if (d == 0)
                {
                    error = "Знаменатель не может быть равен 0.";
                    return false;
                }

                try
                {
                    r = new Rational(n, d);
                    return true;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }

            private static int Gcd(int a, int b)
            {
                while (b != 0)
                {
                    int t = a % b;
                    a = b;
                    b = t;
                }
                return a == 0 ? 1 : a;
            }
        }

        // =========================
        // Настройка таблицы
        // =========================
        private void InitGrid()
        {
            dgvRationals.Columns.Clear();

            dgvRationals.AllowUserToAddRows = false;
            dgvRationals.AllowUserToDeleteRows = false;
            dgvRationals.ReadOnly = true;
            dgvRationals.MultiSelect = false;
            dgvRationals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRationals.RowHeadersVisible = false;
            dgvRationals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRationals.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgvRationals.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNum",
                HeaderText = "Числитель"
            });

            dgvRationals.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDen",
                HeaderText = "Знаменатель"
            });

            dgvRationals.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colValue",
                HeaderText = "Значение"
            });
        }

        private void RefreshGrid()
        {
            dgvRationals.Rows.Clear();

            for (int i = 0; i < items.Count; i++)
            {
                Rational r = (Rational)items[i];
                dgvRationals.Rows.Add(
                    r.Numerator,
                    r.Denominator,
                    r.ToDouble().ToString("0.######", CultureInfo.InvariantCulture)
                );
            }

            UpdateButtonsEnabled();
        }

        private void SetStatus(string text)
        {
            if (lblStatus != null)
                lblStatus.Text = text;
        }

        private void UpdateButtonsEnabled()
        {
            bool hasSelected = GetSelectedIndex() != null;
            btnUpdate.Enabled = hasSelected;
            btnDelete.Enabled = hasSelected;
        }

        private int? GetSelectedIndex()
        {
            if (dgvRationals.CurrentRow == null) return null;

            int idx = dgvRationals.CurrentRow.Index;
            if (idx < 0 || idx >= items.Count) return null;

            return idx;
        }

        private void ClearInputs()
        {
            txtNum.Text = "";
            txtDen.Text = "";
            txtNum.Focus();
        }

        private bool TryReadInput(out Rational r)
        {
            r = null;

            string err;
            if (!Rational.TryParse(txtNum.Text, txtDen.Text, out r, out err))
            {
                MessageBox.Show(err, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LoadSelectedToInputs()
        {
            int? idx = GetSelectedIndex();
            if (idx == null) return;

            Rational r = (Rational)items[idx.Value];
            txtNum.Text = r.Numerator.ToString();
            txtDen.Text = r.Denominator.ToString();
        }

        // =========================
        // События таблицы
        // =========================
        private void DgvRationals_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonsEnabled();
        }

        private void DgvRationals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadSelectedToInputs();
        }

        // =========================
        // Кнопки
        // =========================
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Rational r;
            if (!TryReadInput(out r)) return;

            items.Add(r);
            RefreshGrid();
            SetStatus("Добавлено: " + r.ToString());
            ClearInputs();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int? idx = GetSelectedIndex();
            if (idx == null)
            {
                MessageBox.Show("Выберите элемент в таблице.", "Изменение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Rational r;
            if (!TryReadInput(out r)) return;

            items[idx.Value] = r;
            RefreshGrid();
            SetStatus("Изменено: " + r.ToString());
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int? idx = GetSelectedIndex();
            if (idx == null)
            {
                MessageBox.Show("Выберите элемент в таблице.", "Удаление",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Rational r = (Rational)items[idx.Value];
            items.RemoveAt(idx.Value);

            RefreshGrid();
            SetStatus("Удалено: " + r.ToString());
            ClearInputs();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            SetStatus("Поля очищены");
        }

        // =========================
        // Меню "Коллекция"
        // =========================
        private void MnuCreate_Click(object sender, EventArgs e)
        {
            if (items.Count > 0)
            {
                DialogResult res = MessageBox.Show(
                    "Создать новую коллекцию? Текущая будет очищена.",
                    "Коллекция",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (res != DialogResult.Yes) return;
            }

            items.Clear();
            RefreshGrid();
            ClearInputs();
            SetStatus("Создана новая коллекция");
        }

        private void MnuView_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            SetStatus("Коллекция отображена");
        }

        private void MnuEdit_Click(object sender, EventArgs e)
        {
            int? idx = GetSelectedIndex();
            if (idx == null)
            {
                MessageBox.Show("Выберите элемент в таблице.", "Редактирование",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LoadSelectedToInputs();
            SetStatus("Элемент загружен в поля ввода");
        }

        private void MnuSave_Click(object sender, EventArgs e)
        {
            if (items.Count == 0)
            {
                MessageBox.Show("Коллекция пуста.", "Сохранение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*";
            sfd.Title = "Сохранить коллекцию";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        Rational r = (Rational)items[i];
                        sw.WriteLine(r.Numerator + ";" + r.Denominator);
                    }
                }

                SetStatus("Коллекция сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message, "Сохранение",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*";
            ofd.Title = "Загрузить коллекцию";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            try
            {
                string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);
                ArrayList loaded = new ArrayList();

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] p = line.Split(';');
                    if (p.Length != 2) continue;

                    int n, d;
                    if (!int.TryParse(p[0].Trim(), out n)) continue;
                    if (!int.TryParse(p[1].Trim(), out d)) continue;
                    if (d == 0) continue;

                    loaded.Add(new Rational(n, d));
                }

                items.Clear();
                for (int i = 0; i < loaded.Count; i++)
                    items.Add(loaded[i]);

                RefreshGrid();
                ClearInputs();
                SetStatus("Коллекция загружена");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message, "Загрузка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // =========================
        // Меню "Работа"
        // =========================
        private void MnuSortAsc_Click(object sender, EventArgs e)
        {
            if (items.Count == 0)
            {
                MessageBox.Show("Коллекция пуста.", "Сортировка",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            items.Sort();
            RefreshGrid();
            SetStatus("Отсортировано по возрастанию");
        }

        private void MnuSearchNearestToAverage_Click(object sender, EventArgs e)
        {
            if (items.Count == 0)
            {
                MessageBox.Show("Коллекция пуста.", "Поиск",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double sum = 0.0;
            for (int i = 0; i < items.Count; i++)
                sum += ((Rational)items[i]).ToDouble();

            double avg = sum / items.Count;

            int bestIdx = 0;
            double bestDiff = Math.Abs(((Rational)items[0]).ToDouble() - avg);

            for (int i = 1; i < items.Count; i++)
            {
                double diff = Math.Abs(((Rational)items[i]).ToDouble() - avg);
                if (diff < bestDiff)
                {
                    bestDiff = diff;
                    bestIdx = i;
                }
            }

            dgvRationals.ClearSelection();
            if (bestIdx >= 0 && bestIdx < dgvRationals.Rows.Count)
            {
                dgvRationals.Rows[bestIdx].Selected = true;
                dgvRationals.CurrentCell = dgvRationals.Rows[bestIdx].Cells[0];
            }

            Rational best = (Rational)items[bestIdx];

            MessageBox.Show(
                "Среднее значение: " + avg.ToString("0.######", CultureInfo.InvariantCulture) + "\n" +
                "Найдено: " + best.ToString() + " (≈ " + best.ToDouble().ToString("0.######", CultureInfo.InvariantCulture) + ")\n" +
                "Отклонение: " + bestDiff.ToString("0.######", CultureInfo.InvariantCulture),
                "Результат поиска",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            SetStatus("Поиск выполнен");
        }

        private void MnuTaskRangeNewCollection_Click(object sender, EventArgs e)
        {
            if (items.Count == 0)
            {
                MessageBox.Show("Коллекция пуста.", "Задание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (RangeForm rf = new RangeForm())
            {
                if (rf.ShowDialog() != DialogResult.OK) return;

                Rational left = rf.LeftBound;
                Rational right = rf.RightBound;

                if (left.CompareTo(right) > 0)
                {
                    Rational tmp = left;
                    left = right;
                    right = tmp;
                }

                ArrayList newList = new ArrayList();
                for (int i = 0; i < items.Count; i++)
                {
                    Rational r = (Rational)items[i];
                    if (r.CompareTo(left) >= 0 && r.CompareTo(right) <= 0)
                        newList.Add(r);
                }

                items.Clear();
                for (int i = 0; i < newList.Count; i++)
                    items.Add(newList[i]);

                RefreshGrid();
                ClearInputs();

                MessageBox.Show(
                    "Новая коллекция сформирована. Количество элементов: " + items.Count,
                    "Задание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                SetStatus("Задание выполнено");
            }
        }

        // =========================
        // О программе
        // =========================
        private void MnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Лабораторная работа №7\nМассивы и коллекции C#\nArrayList, класс Rational (вариант 11).",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    // =========================
    // Окно ввода промежутка
    // =========================
    public class RangeForm : Form
    {
        private TextBox txtNum1;
        private TextBox txtDen1;
        private TextBox txtNum2;
        private TextBox txtDen2;
        private Button btnOk;
        private Button btnCancel;

        public Form1.Rational LeftBound { get; private set; }
        public Form1.Rational RightBound { get; private set; }

        public RangeForm()
        {
            Text = "Промежуток";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Width = 420;
            Height = 180;

            Label l1 = new Label { Left = 10, Top = 15, Width = 190, Text = "Левая граница (числ/знам)" };
            Label l2 = new Label { Left = 10, Top = 55, Width = 190, Text = "Правая граница (числ/знам)" };

            txtNum1 = new TextBox { Left = 210, Top = 12, Width = 70 };
            txtDen1 = new TextBox { Left = 290, Top = 12, Width = 70 };

            txtNum2 = new TextBox { Left = 210, Top = 52, Width = 70 };
            txtDen2 = new TextBox { Left = 290, Top = 52, Width = 70 };

            btnOk = new Button { Left = 210, Top = 90, Width = 70, Text = "OK" };
            btnCancel = new Button { Left = 290, Top = 90, Width = 70, Text = "Отмена" };

            btnOk.Click += BtnOk_Click;
            btnCancel.Click += BtnCancel_Click;

            Controls.Add(l1);
            Controls.Add(l2);
            Controls.Add(txtNum1);
            Controls.Add(txtDen1);
            Controls.Add(txtNum2);
            Controls.Add(txtDen2);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Form1.Rational left;
            Form1.Rational right;
            string err1;
            string err2;

            if (!Form1.Rational.TryParse(txtNum1.Text, txtDen1.Text, out left, out err1))
            {
                MessageBox.Show(err1, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Form1.Rational.TryParse(txtNum2.Text, txtDen2.Text, out right, out err2))
            {
                MessageBox.Show(err2, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LeftBound = left;
            RightBound = right;
            DialogResult = DialogResult.OK;
        }
    }
}
