namespace Nikitin_CSharp
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
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.threadList = new System.Windows.Forms.ComboBox();
            this.threadCounter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.button_snd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.threadCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(82, 128);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(111, 36);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_stop.Location = new System.Drawing.Point(210, 128);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(115, 36);
            this.button_stop.TabIndex = 1;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // threadList
            // 
            this.threadList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threadList.FormattingEnabled = true;
            this.threadList.Location = new System.Drawing.Point(490, 64);
            this.threadList.Name = "threadList";
            this.threadList.Size = new System.Drawing.Size(159, 29);
            this.threadList.TabIndex = 2;
            // 
            // threadCounter
            // 
            this.threadCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threadCounter.Location = new System.Drawing.Point(248, 43);
            this.threadCounter.Name = "threadCounter";
            this.threadCounter.Size = new System.Drawing.Size(77, 29);
            this.threadCounter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose number of threads:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(495, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "List of threads:";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(82, 238);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(243, 20);
            this.txtBox.TabIndex = 6;
            // 
            // button_snd
            // 
            this.button_snd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_snd.Location = new System.Drawing.Point(513, 229);
            this.button_snd.Name = "button_snd";
            this.button_snd.Size = new System.Drawing.Size(113, 36);
            this.button_snd.TabIndex = 7;
            this.button_snd.Text = "Send";
            this.button_snd.UseVisualStyleBackColor = true;
            this.button_snd.Click += new System.EventHandler(this.button_snd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_snd);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.threadCounter);
            this.Controls.Add(this.threadList);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCls);
            ((System.ComponentModel.ISupportInitialize)(this.threadCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.ComboBox threadList;
        private System.Windows.Forms.NumericUpDown threadCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button button_snd;
    }
}

