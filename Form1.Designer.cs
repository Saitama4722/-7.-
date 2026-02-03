namespace Lab07
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWork = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSortAsc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchNearestToAverage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTask = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaskRangeNewCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRationals = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDen = new System.Windows.Forms.MaskedTextBox();
            this.lblDen = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.MaskedTextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRationals)).BeginInit();
            this.grpInput.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuWork,
            this.mnuAbout});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(884, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCollection,
            this.mnuCreate,
            this.mnuView,
            this.mnuEdit,
            this.mnuSave,
            this.mnuLoad,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(48, 20);
            this.mnuFile.Text = "Файл";
            // 
            // mnuCollection
            // 
            this.mnuCollection.Name = "mnuCollection";
            this.mnuCollection.Size = new System.Drawing.Size(154, 22);
            this.mnuCollection.Text = "Коллекция";
            // 
            // mnuCreate
            // 
            this.mnuCreate.Name = "mnuCreate";
            this.mnuCreate.Size = new System.Drawing.Size(154, 22);
            this.mnuCreate.Text = "Создать";
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(154, 22);
            this.mnuView.Text = "Просмотреть";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(154, 22);
            this.mnuEdit.Text = "Редактировать";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(154, 22);
            this.mnuSave.Text = "Сохранить";
            // 
            // mnuLoad
            // 
            this.mnuLoad.Name = "mnuLoad";
            this.mnuLoad.Size = new System.Drawing.Size(154, 22);
            this.mnuLoad.Text = "Загрузить";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(154, 22);
            this.mnuExit.Text = "Выход";
            // 
            // mnuWork
            // 
            this.mnuWork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSort,
            this.mnuSortAsc,
            this.mnuSearch,
            this.mnuSearchNearestToAverage,
            this.mnuTask,
            this.mnuTaskRangeNewCollection});
            this.mnuWork.Name = "mnuWork";
            this.mnuWork.Size = new System.Drawing.Size(57, 20);
            this.mnuWork.Text = "Работа";
            // 
            // mnuSort
            // 
            this.mnuSort.Name = "mnuSort";
            this.mnuSort.Size = new System.Drawing.Size(660, 22);
            this.mnuSort.Text = "Сортировка";
            // 
            // mnuSortAsc
            // 
            this.mnuSortAsc.Name = "mnuSortAsc";
            this.mnuSortAsc.Size = new System.Drawing.Size(660, 22);
            this.mnuSortAsc.Text = "По возрастанию";
            // 
            // mnuSearch
            // 
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.Size = new System.Drawing.Size(660, 22);
            this.mnuSearch.Text = "Поиск";
            // 
            // mnuSearchNearestToAverage
            // 
            this.mnuSearchNearestToAverage.Name = "mnuSearchNearestToAverage";
            this.mnuSearchNearestToAverage.Size = new System.Drawing.Size(660, 22);
            this.mnuSearchNearestToAverage.Text = "Дроби, наименьше отличающейся от среднего значения всех элементов коллекции";
            // 
            // mnuTask
            // 
            this.mnuTask.Name = "mnuTask";
            this.mnuTask.Size = new System.Drawing.Size(660, 22);
            this.mnuTask.Text = "Задание";
            // 
            // mnuTaskRangeNewCollection
            // 
            this.mnuTaskRangeNewCollection.Name = "mnuTaskRangeNewCollection";
            this.mnuTaskRangeNewCollection.Size = new System.Drawing.Size(660, 22);
            this.mnuTaskRangeNewCollection.Text = "Создать новую коллекцию, в которой будут размещены дроби из указанного пользовате" +
    "лем промежутка";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(94, 20);
            this.mnuAbout.Text = "О программе";
            // 
            // dgvRationals
            // 
            this.dgvRationals.AllowUserToAddRows = false;
            this.dgvRationals.AllowUserToDeleteRows = false;
            this.dgvRationals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRationals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRationals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colDen,
            this.colValue});
            this.dgvRationals.Location = new System.Drawing.Point(0, 27);
            this.dgvRationals.MultiSelect = false;
            this.dgvRationals.Name = "dgvRationals";
            this.dgvRationals.ReadOnly = true;
            this.dgvRationals.RowHeadersVisible = false;
            this.dgvRationals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRationals.Size = new System.Drawing.Size(401, 459);
            this.dgvRationals.TabIndex = 1;
            // 
            // colNum
            // 
            this.colNum.HeaderText = "Числитель";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            // 
            // colDen
            // 
            this.colDen.HeaderText = "Знаменатель";
            this.colDen.Name = "colDen";
            this.colDen.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Значение";
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnClear);
            this.grpInput.Controls.Add(this.btnDelete);
            this.grpInput.Controls.Add(this.btnUpdate);
            this.grpInput.Controls.Add(this.btnAdd);
            this.grpInput.Controls.Add(this.txtDen);
            this.grpInput.Controls.Add(this.lblDen);
            this.grpInput.Controls.Add(this.txtNum);
            this.grpInput.Controls.Add(this.lblNum);
            this.grpInput.Location = new System.Drawing.Point(407, 27);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(465, 92);
            this.grpInput.TabIndex = 2;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Ввод дроби";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(223, 63);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(304, 63);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(304, 34);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(223, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(117, 36);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(100, 20);
            this.txtDen.TabIndex = 3;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(114, 16);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(75, 13);
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "Знаменатель";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(10, 36);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 1;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(7, 20);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(62, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Числитель";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 489);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(884, 22);
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 17);
            this.lblStatus.Text = "Готово";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.dgvRationals);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №7. Массивы и коллекции";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRationals)).EndInit();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuCollection;
        private System.Windows.Forms.ToolStripMenuItem mnuCreate;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuWork;
        private System.Windows.Forms.ToolStripMenuItem mnuSort;
        private System.Windows.Forms.ToolStripMenuItem mnuSortAsc;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchNearestToAverage;
        private System.Windows.Forms.ToolStripMenuItem mnuTask;
        private System.Windows.Forms.ToolStripMenuItem mnuTaskRangeNewCollection;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.DataGridView dgvRationals;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox txtDen;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.MaskedTextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

