
namespace Among_Us_Choose_Your_Adventure
{
    partial class Form1
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
            this.Title = new System.Windows.Forms.Label();
            this.QuestionBox = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.Button();
            this.Option2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Black;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(128, 81);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(459, 81);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title Box";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuestionBox
            // 
            this.QuestionBox.BackColor = System.Drawing.Color.Black;
            this.QuestionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionBox.ForeColor = System.Drawing.Color.White;
            this.QuestionBox.Location = new System.Drawing.Point(200, 152);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(315, 48);
            this.QuestionBox.TabIndex = 1;
            this.QuestionBox.Text = "Question Box";
            this.QuestionBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Option1
            // 
            this.Option1.BackColor = System.Drawing.Color.Black;
            this.Option1.ForeColor = System.Drawing.Color.White;
            this.Option1.Location = new System.Drawing.Point(132, 241);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(94, 38);
            this.Option1.TabIndex = 2;
            this.Option1.Text = "Option 1";
            this.Option1.UseVisualStyleBackColor = false;
            this.Option1.Click += new System.EventHandler(this.Option1_Click);
            // 
            // Option2
            // 
            this.Option2.BackColor = System.Drawing.Color.Black;
            this.Option2.ForeColor = System.Drawing.Color.White;
            this.Option2.Location = new System.Drawing.Point(487, 241);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(94, 38);
            this.Option2.TabIndex = 3;
            this.Option2.Text = "Option 2";
            this.Option2.UseVisualStyleBackColor = false;
            this.Option2.Click += new System.EventHandler(this.Option2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Among_Us_Choose_Your_Adventure.Properties.Resources.Start_Scene;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label QuestionBox;
        private System.Windows.Forms.Button Option1;
        private System.Windows.Forms.Button Option2;
    }
}

