namespace MongoForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreateDb = new Button();
            btnDropCollection = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnReplace = new Button();
            btnInsertMany = new Button();
            btnUpdateMany = new Button();
            btnComplexFilters = new Button();
            btnFindAndUpdate = new Button();
            btnSimpleCount = new Button();
            btnBulkUpsert = new Button();
            btnPagination = new Button();
            btnCreateIndex = new Button();
            btnCursorBatch = new Button();
            btnTransaction = new Button();
            btnPopulateEdition = new Button();
            btnLookUp = new Button();
            btnFindAll = new Button();
            btnUnwind = new Button();
            SuspendLayout();
            // 
            // btnCreateDb
            // 
            btnCreateDb.Location = new Point(13, 58);
            btnCreateDb.Name = "btnCreateDb";
            btnCreateDb.Size = new Size(210, 23);
            btnCreateDb.TabIndex = 0;
            btnCreateDb.Text = "Create Db";
            btnCreateDb.UseVisualStyleBackColor = true;
            btnCreateDb.Click += btnCreateDb_Click;
            // 
            // btnDropCollection
            // 
            btnDropCollection.Location = new Point(13, 29);
            btnDropCollection.Name = "btnDropCollection";
            btnDropCollection.Size = new Size(210, 23);
            btnDropCollection.TabIndex = 1;
            btnDropCollection.Text = "Drop Collection";
            btnDropCollection.UseVisualStyleBackColor = true;
            btnDropCollection.Click += btnDropCollection_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 87);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(211, 23);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(13, 116);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(209, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnReplace
            // 
            btnReplace.Location = new Point(13, 145);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(210, 23);
            btnReplace.TabIndex = 5;
            btnReplace.Text = "Replace";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // btnInsertMany
            // 
            btnInsertMany.Location = new Point(229, 29);
            btnInsertMany.Name = "btnInsertMany";
            btnInsertMany.Size = new Size(210, 23);
            btnInsertMany.TabIndex = 6;
            btnInsertMany.Text = "Insert Many";
            btnInsertMany.UseVisualStyleBackColor = true;
            btnInsertMany.Click += btnInsertMany_Click;
            // 
            // btnUpdateMany
            // 
            btnUpdateMany.Location = new Point(229, 58);
            btnUpdateMany.Name = "btnUpdateMany";
            btnUpdateMany.Size = new Size(210, 23);
            btnUpdateMany.TabIndex = 7;
            btnUpdateMany.Text = "Update Many";
            btnUpdateMany.UseVisualStyleBackColor = true;
            btnUpdateMany.Click += btnUpdateMany_Click;
            // 
            // btnComplexFilters
            // 
            btnComplexFilters.Location = new Point(229, 87);
            btnComplexFilters.Name = "btnComplexFilters";
            btnComplexFilters.Size = new Size(210, 23);
            btnComplexFilters.TabIndex = 8;
            btnComplexFilters.Text = "Complex Filters";
            btnComplexFilters.UseVisualStyleBackColor = true;
            btnComplexFilters.Click += btnComplexFilters_Click;
            // 
            // btnFindAndUpdate
            // 
            btnFindAndUpdate.Location = new Point(229, 116);
            btnFindAndUpdate.Name = "btnFindAndUpdate";
            btnFindAndUpdate.Size = new Size(210, 23);
            btnFindAndUpdate.TabIndex = 9;
            btnFindAndUpdate.Text = "Find And Update";
            btnFindAndUpdate.UseVisualStyleBackColor = true;
            btnFindAndUpdate.Click += btnFindAndUpdate_Click;
            // 
            // btnSimpleCount
            // 
            btnSimpleCount.Location = new Point(229, 145);
            btnSimpleCount.Name = "btnSimpleCount";
            btnSimpleCount.Size = new Size(210, 23);
            btnSimpleCount.TabIndex = 10;
            btnSimpleCount.Text = "Simple Count";
            btnSimpleCount.UseVisualStyleBackColor = true;
            btnSimpleCount.Click += btnSimpleCount_Click;
            // 
            // btnBulkUpsert
            // 
            btnBulkUpsert.Location = new Point(445, 29);
            btnBulkUpsert.Name = "btnBulkUpsert";
            btnBulkUpsert.Size = new Size(210, 23);
            btnBulkUpsert.TabIndex = 11;
            btnBulkUpsert.Text = "Bulk Upsert";
            btnBulkUpsert.UseVisualStyleBackColor = true;
            btnBulkUpsert.Click += btnBulkUpsert_Click;
            // 
            // btnPagination
            // 
            btnPagination.Location = new Point(445, 58);
            btnPagination.Name = "btnPagination";
            btnPagination.Size = new Size(210, 23);
            btnPagination.TabIndex = 12;
            btnPagination.Text = "Pagination";
            btnPagination.UseVisualStyleBackColor = true;
            btnPagination.Click += btnPagination_Click;
            // 
            // btnCreateIndex
            // 
            btnCreateIndex.Location = new Point(445, 87);
            btnCreateIndex.Name = "btnCreateIndex";
            btnCreateIndex.Size = new Size(210, 23);
            btnCreateIndex.TabIndex = 13;
            btnCreateIndex.Text = "Create Index";
            btnCreateIndex.UseVisualStyleBackColor = true;
            btnCreateIndex.Click += btnCreateIndex_Click;
            // 
            // btnCursorBatch
            // 
            btnCursorBatch.Location = new Point(445, 116);
            btnCursorBatch.Name = "btnCursorBatch";
            btnCursorBatch.Size = new Size(210, 23);
            btnCursorBatch.TabIndex = 14;
            btnCursorBatch.Text = "Cursor Batch";
            btnCursorBatch.UseVisualStyleBackColor = true;
            btnCursorBatch.Click += btnCursorBatch_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.Location = new Point(445, 145);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(210, 23);
            btnTransaction.TabIndex = 15;
            btnTransaction.Text = "Transaction";
            btnTransaction.UseVisualStyleBackColor = true;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnPopulateEdition
            // 
            btnPopulateEdition.Location = new Point(13, 202);
            btnPopulateEdition.Name = "btnPopulateEdition";
            btnPopulateEdition.Size = new Size(210, 23);
            btnPopulateEdition.TabIndex = 16;
            btnPopulateEdition.Text = "Populate Edition";
            btnPopulateEdition.UseVisualStyleBackColor = true;
            btnPopulateEdition.Click += btnPopulateEdition_Click;
            // 
            // btnLookUp
            // 
            btnLookUp.Location = new Point(13, 231);
            btnLookUp.Name = "btnLookUp";
            btnLookUp.Size = new Size(210, 23);
            btnLookUp.TabIndex = 17;
            btnLookUp.Text = "LookUp";
            btnLookUp.UseVisualStyleBackColor = true;
            btnLookUp.Click += btnLookUp_Click;
            // 
            // btnFindAll
            // 
            btnFindAll.Location = new Point(229, 202);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(210, 23);
            btnFindAll.TabIndex = 18;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // btnUnwind
            // 
            btnUnwind.Location = new Point(229, 231);
            btnUnwind.Name = "btnUnwind";
            btnUnwind.Size = new Size(210, 23);
            btnUnwind.TabIndex = 19;
            btnUnwind.Text = "Unwind";
            btnUnwind.UseVisualStyleBackColor = true;
            btnUnwind.Click += btnUnwind_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUnwind);
            Controls.Add(btnFindAll);
            Controls.Add(btnLookUp);
            Controls.Add(btnPopulateEdition);
            Controls.Add(btnTransaction);
            Controls.Add(btnCursorBatch);
            Controls.Add(btnCreateIndex);
            Controls.Add(btnPagination);
            Controls.Add(btnBulkUpsert);
            Controls.Add(btnSimpleCount);
            Controls.Add(btnFindAndUpdate);
            Controls.Add(btnComplexFilters);
            Controls.Add(btnUpdateMany);
            Controls.Add(btnInsertMany);
            Controls.Add(btnReplace);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnDropCollection);
            Controls.Add(btnCreateDb);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateDb;
        private Button btnDropCollection;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnReplace;
        private Button btnInsertMany;
        private Button btnUpdateMany;
        private Button btnComplexFilters;
        private Button btnFindAndUpdate;
        private Button btnSimpleCount;
        private Button btnBulkUpsert;
        private Button btnPagination;
        private Button btnCreateIndex;
        private Button btnCursorBatch;
        private Button btnTransaction;
        private Button btnPopulateEdition;
        private Button btnLookUp;
        private Button btnFindAll;
        private Button btnUnwind;
    }
}