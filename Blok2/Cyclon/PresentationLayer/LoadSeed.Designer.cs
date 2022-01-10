namespace PresentationLayer;

partial class LoadSeed
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.UseSelectedSeedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 29;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(609, 264);
            this.DataGrid.TabIndex = 0;
            // 
            // UseSelectedSeedButton
            // 
            this.UseSelectedSeedButton.AutoSize = true;
            this.UseSelectedSeedButton.BackColor = System.Drawing.Color.Honeydew;
            this.UseSelectedSeedButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UseSelectedSeedButton.Location = new System.Drawing.Point(0, 234);
            this.UseSelectedSeedButton.Name = "UseSelectedSeedButton";
            this.UseSelectedSeedButton.Size = new System.Drawing.Size(609, 30);
            this.UseSelectedSeedButton.TabIndex = 1;
            this.UseSelectedSeedButton.Text = "Copy seed to clipboard";
            this.UseSelectedSeedButton.UseVisualStyleBackColor = false;
            this.UseSelectedSeedButton.Click += new System.EventHandler(this.UseSelectedSeedButton_Click);
            // 
            // LoadSeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(609, 264);
            this.Controls.Add(this.UseSelectedSeedButton);
            this.Controls.Add(this.DataGrid);
            this.Name = "LoadSeed";
            this.Text = "LoadSeed";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private DataGridView DataGrid;
    private Button UseSelectedSeedButton;
}
