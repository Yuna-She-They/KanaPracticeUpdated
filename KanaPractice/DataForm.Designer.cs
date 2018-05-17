namespace KanaPractice
{
    /// <summary>
    /// 
    /// </summary>
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.kanaDataSet = new KanaPractice.KanaDataSet();
            this.kanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kanaTableAdapter = new KanaPractice.KanaDataSetTableAdapters.KanaTableAdapter();
            this.tableAdapterManager = new KanaPractice.KanaDataSetTableAdapters.TableAdapterManager();
            this.kanaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kanaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kanaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.radLearn = new System.Windows.Forms.RadioButton();
            this.radStudy = new System.Windows.Forms.RadioButton();
            this.grpKana = new System.Windows.Forms.GroupBox();
            this.radKatakana = new System.Windows.Forms.RadioButton();
            this.radHiragana = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblKana = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanaBindingNavigator)).BeginInit();
            this.kanaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kanaDataGridView)).BeginInit();
            this.grpMode.SuspendLayout();
            this.grpKana.SuspendLayout();
            this.SuspendLayout();
            // 
            // kanaDataSet
            // 
            this.kanaDataSet.DataSetName = "KanaDataSet";
            this.kanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kanaBindingSource
            // 
            this.kanaBindingSource.DataMember = "Kana";
            this.kanaBindingSource.DataSource = this.kanaDataSet;
            // 
            // kanaTableAdapter
            // 
            this.kanaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KanaTableAdapter = this.kanaTableAdapter;
            this.tableAdapterManager.UpdateOrder = KanaPractice.KanaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kanaBindingNavigator
            // 
            this.kanaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kanaBindingNavigator.BindingSource = this.kanaBindingSource;
            this.kanaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kanaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kanaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.kanaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kanaBindingNavigatorSaveItem});
            this.kanaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kanaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kanaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kanaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kanaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kanaBindingNavigator.Name = "kanaBindingNavigator";
            this.kanaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kanaBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.kanaBindingNavigator.TabIndex = 0;
            this.kanaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // kanaBindingNavigatorSaveItem
            // 
            this.kanaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kanaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kanaBindingNavigatorSaveItem.Image")));
            this.kanaBindingNavigatorSaveItem.Name = "kanaBindingNavigatorSaveItem";
            this.kanaBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.kanaBindingNavigatorSaveItem.Text = "Save Data";
            this.kanaBindingNavigatorSaveItem.Click += new System.EventHandler(this.kanaBindingNavigatorSaveItem_Click);
            // 
            // kanaDataGridView
            // 
            this.kanaDataGridView.AutoGenerateColumns = false;
            this.kanaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kanaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.kanaDataGridView.DataSource = this.kanaBindingSource;
            this.kanaDataGridView.Location = new System.Drawing.Point(12, 36);
            this.kanaDataGridView.Name = "kanaDataGridView";
            this.kanaDataGridView.RowTemplate.Height = 28;
            this.kanaDataGridView.Size = new System.Drawing.Size(451, 220);
            this.kanaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Romanji";
            this.dataGridViewTextBoxColumn2.HeaderText = "Romanji";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Katakana";
            this.dataGridViewTextBoxColumn3.HeaderText = "Katakana";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Hiragana";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hiragana";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.radStudy);
            this.grpMode.Controls.Add(this.radLearn);
            this.grpMode.Location = new System.Drawing.Point(469, 36);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(99, 104);
            this.grpMode.TabIndex = 2;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Play Mode";
            // 
            // radLearn
            // 
            this.radLearn.AutoSize = true;
            this.radLearn.Location = new System.Drawing.Point(6, 37);
            this.radLearn.Name = "radLearn";
            this.radLearn.Size = new System.Drawing.Size(75, 24);
            this.radLearn.TabIndex = 0;
            this.radLearn.TabStop = true;
            this.radLearn.Text = "Learn";
            this.radLearn.UseVisualStyleBackColor = true;
            // 
            // radStudy
            // 
            this.radStudy.AutoSize = true;
            this.radStudy.Location = new System.Drawing.Point(7, 68);
            this.radStudy.Name = "radStudy";
            this.radStudy.Size = new System.Drawing.Size(75, 24);
            this.radStudy.TabIndex = 1;
            this.radStudy.TabStop = true;
            this.radStudy.Text = "Study";
            this.radStudy.UseVisualStyleBackColor = true;
            // 
            // grpKana
            // 
            this.grpKana.Controls.Add(this.radHiragana);
            this.grpKana.Controls.Add(this.radKatakana);
            this.grpKana.Location = new System.Drawing.Point(575, 36);
            this.grpKana.Name = "grpKana";
            this.grpKana.Size = new System.Drawing.Size(200, 100);
            this.grpKana.TabIndex = 3;
            this.grpKana.TabStop = false;
            this.grpKana.Text = "Kana";
            // 
            // radKatakana
            // 
            this.radKatakana.AutoSize = true;
            this.radKatakana.Location = new System.Drawing.Point(7, 37);
            this.radKatakana.Name = "radKatakana";
            this.radKatakana.Size = new System.Drawing.Size(102, 24);
            this.radKatakana.TabIndex = 0;
            this.radKatakana.TabStop = true;
            this.radKatakana.Text = "Katakana";
            this.radKatakana.UseVisualStyleBackColor = true;
            // 
            // radHiragana
            // 
            this.radHiragana.AutoSize = true;
            this.radHiragana.Location = new System.Drawing.Point(7, 68);
            this.radHiragana.Name = "radHiragana";
            this.radHiragana.Size = new System.Drawing.Size(99, 24);
            this.radHiragana.TabIndex = 1;
            this.radHiragana.TabStop = true;
            this.radHiragana.Text = "Hiragana";
            this.radHiragana.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(485, 159);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(83, 30);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblKana
            // 
            this.lblKana.AutoSize = true;
            this.lblKana.Location = new System.Drawing.Point(31, 333);
            this.lblKana.Name = "lblKana";
            this.lblKana.Size = new System.Drawing.Size(61, 20);
            this.lblKana.TabIndex = 5;
            this.lblKana.Text = "lblKana";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(121, 332);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(51, 20);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "label1";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(35, 407);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(137, 26);
            this.txtGuess.TabIndex = 7;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(231, 407);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 27);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblKana);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpKana);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.kanaDataGridView);
            this.Controls.Add(this.kanaBindingNavigator);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kanaBindingNavigator)).EndInit();
            this.kanaBindingNavigator.ResumeLayout(false);
            this.kanaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kanaDataGridView)).EndInit();
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.grpKana.ResumeLayout(false);
            this.grpKana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KanaDataSet kanaDataSet;
        private System.Windows.Forms.BindingSource kanaBindingSource;
        private KanaDataSetTableAdapters.KanaTableAdapter kanaTableAdapter;
        private KanaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kanaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kanaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kanaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.RadioButton radStudy;
        private System.Windows.Forms.RadioButton radLearn;
        private System.Windows.Forms.GroupBox grpKana;
        private System.Windows.Forms.RadioButton radHiragana;
        private System.Windows.Forms.RadioButton radKatakana;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblKana;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnCheck;
    }
}