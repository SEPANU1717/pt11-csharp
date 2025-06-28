namespace FrmCalculator;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtBoxInput1 = new System.Windows.Forms.TextBox();
        cbOperator = new System.Windows.Forms.ComboBox();
        txtBoxInput2 = new System.Windows.Forms.TextBox();
        btnEqual = new System.Windows.Forms.Button();
        lblDisplayTotal = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // txtBoxInput1
        // 
        txtBoxInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtBoxInput1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBoxInput1.Location = new System.Drawing.Point(287, 131);
        txtBoxInput1.Name = "txtBoxInput1";
        txtBoxInput1.Size = new System.Drawing.Size(158, 29);
        txtBoxInput1.TabIndex = 0;
        // 
        // cbOperator
        // 
        cbOperator.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        cbOperator.FormattingEnabled = true;
        cbOperator.Location = new System.Drawing.Point(287, 178);
        cbOperator.Name = "cbOperator";
        cbOperator.Size = new System.Drawing.Size(71, 27);
        cbOperator.TabIndex = 1;
        // 
        // txtBoxInput2
        // 
        txtBoxInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        txtBoxInput2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtBoxInput2.Location = new System.Drawing.Point(287, 220);
        txtBoxInput2.Name = "txtBoxInput2";
        txtBoxInput2.Size = new System.Drawing.Size(158, 29);
        txtBoxInput2.TabIndex = 2;
        // 
        // btnEqual
        // 
        btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)((byte)131)), ((int)((byte)197)), ((int)((byte)190)));
        btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnEqual.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnEqual.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)247)), ((int)((byte)255)), ((int)((byte)247)));
        btnEqual.Location = new System.Drawing.Point(287, 308);
        btnEqual.Name = "btnEqual";
        btnEqual.Size = new System.Drawing.Size(158, 33);
        btnEqual.TabIndex = 3;
        btnEqual.Text = "Calculate";
        btnEqual.UseVisualStyleBackColor = false;
        btnEqual.Click += btnEqual_Click;
        // 
        // lblDisplayTotal
        // 
        lblDisplayTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblDisplayTotal.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)247)), ((int)((byte)255)), ((int)((byte)247)));
        lblDisplayTotal.Location = new System.Drawing.Point(369, 269);
        lblDisplayTotal.Name = "lblDisplayTotal";
        lblDisplayTotal.Size = new System.Drawing.Size(76, 23);
        lblDisplayTotal.TabIndex = 4;
        lblDisplayTotal.Text = "<total>";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)247)), ((int)((byte)255)), ((int)((byte)247)));
        label2.Location = new System.Drawing.Point(88, 137);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(142, 23);
        label2.TabIndex = 5;
        label2.Text = "Enter First Number";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)247)), ((int)((byte)255)), ((int)((byte)247)));
        label3.Location = new System.Drawing.Point(88, 226);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(166, 23);
        label3.TabIndex = 6;
        label3.Text = "Enter Second Number";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)247)), ((int)((byte)255)), ((int)((byte)247)));
        label4.Location = new System.Drawing.Point(88, 182);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(142, 23);
        label4.TabIndex = 7;
        label4.Text = "Select Operator";
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)247)), ((int)((byte)255)), ((int)((byte)247)));
        label1.Location = new System.Drawing.Point(127, 53);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(289, 49);
        label1.TabIndex = 8;
        label1.Text = "Calculator Application";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)88)), ((int)((byte)139)), ((int)((byte)139)));
        ClientSize = new System.Drawing.Size(543, 413);
        Controls.Add(label1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(lblDisplayTotal);
        Controls.Add(btnEqual);
        Controls.Add(txtBoxInput2);
        Controls.Add(cbOperator);
        Controls.Add(txtBoxInput1);
        Text = "frmCalculator";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label lblDisplayTotal;

    private System.Windows.Forms.Button btnEqual;

    private System.Windows.Forms.TextBox txtBoxInput2;

    private System.Windows.Forms.TextBox txtBoxInput1;
    private System.Windows.Forms.ComboBox cbOperator;

    #endregion
}