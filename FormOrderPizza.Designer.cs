namespace PizzaProject2
{
    partial class FormOrderPizza
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmallSize = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlves = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushroums = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatin = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.lblOrdrerPrise2 = new System.Windows.Forms.Label();
            this.lblWhereEat = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbLarg);
            this.groupBox1.Controls.Add(this.rbMeduim);
            this.groupBox1.Controls.Add(this.rbSmallSize);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(34, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Location = new System.Drawing.Point(16, 182);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(83, 34);
            this.rbLarg.TabIndex = 2;
            this.rbLarg.Tag = "50";
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Checked = true;
            this.rbMeduim.Location = new System.Drawing.Point(16, 115);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(116, 34);
            this.rbMeduim.TabIndex = 1;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "40";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmallSize
            // 
            this.rbSmallSize.AutoSize = true;
            this.rbSmallSize.Location = new System.Drawing.Point(18, 53);
            this.rbSmallSize.Name = "rbSmallSize";
            this.rbSmallSize.Size = new System.Drawing.Size(93, 34);
            this.rbSmallSize.TabIndex = 0;
            this.rbSmallSize.Tag = "30";
            this.rbSmallSize.Text = "Small";
            this.rbSmallSize.UseVisualStyleBackColor = true;
            this.rbSmallSize.CheckedChanged += new System.EventHandler(this.rbSmallSize_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkGreenPeppers);
            this.groupBox2.Controls.Add(this.chkOlves);
            this.groupBox2.Controls.Add(this.chkOnion);
            this.groupBox2.Controls.Add(this.chkTomatoes);
            this.groupBox2.Controls.Add(this.chkMushroums);
            this.groupBox2.Controls.Add(this.chkExtraChees);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(369, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "5";
            this.groupBox2.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.Location = new System.Drawing.Point(174, 173);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(158, 28);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlves
            // 
            this.chkOlves.AutoSize = true;
            this.chkOlves.Location = new System.Drawing.Point(174, 115);
            this.chkOlves.Name = "chkOlves";
            this.chkOlves.Size = new System.Drawing.Size(97, 34);
            this.chkOlves.TabIndex = 4;
            this.chkOlves.Text = "Olves";
            this.chkOlves.UseVisualStyleBackColor = true;
            this.chkOlves.CheckedChanged += new System.EventHandler(this.chkOlves_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(174, 54);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(99, 34);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(18, 173);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(139, 34);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushroums
            // 
            this.chkMushroums.AutoSize = true;
            this.chkMushroums.Location = new System.Drawing.Point(18, 116);
            this.chkMushroums.Name = "chkMushroums";
            this.chkMushroums.Size = new System.Drawing.Size(153, 34);
            this.chkMushroums.TabIndex = 1;
            this.chkMushroums.Tag = "5";
            this.chkMushroums.Text = "Mushroums";
            this.chkMushroums.UseVisualStyleBackColor = true;
            this.chkMushroums.CheckedChanged += new System.EventHandler(this.chkMushroums_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(19, 53);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(164, 34);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rbThinkCrust);
            this.groupBox3.Controls.Add(this.rbThinCrust);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(34, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crust Type";
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.Location = new System.Drawing.Point(35, 75);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(158, 34);
            this.rbThinkCrust.TabIndex = 2;
            this.rbThinkCrust.Tag = "10";
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = true;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Location = new System.Drawing.Point(35, 37);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(145, 34);
            this.rbThinCrust.TabIndex = 1;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rbTakeOut);
            this.groupBox4.Controls.Add(this.rbEatin);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(369, 409);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 115);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(152, 57);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(135, 34);
            this.rbTakeOut.TabIndex = 2;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatin
            // 
            this.rbEatin.AutoSize = true;
            this.rbEatin.Checked = true;
            this.rbEatin.Location = new System.Drawing.Point(26, 57);
            this.rbEatin.Name = "rbEatin";
            this.rbEatin.Size = new System.Drawing.Size(98, 34);
            this.rbEatin.TabIndex = 1;
            this.rbEatin.TabStop = true;
            this.rbEatin.Text = "Eat in";
            this.rbEatin.UseVisualStyleBackColor = true;
            this.rbEatin.CheckedChanged += new System.EventHandler(this.rbEatin_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(314, 609);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(179, 65);
            this.btnOrderPizza.TabIndex = 4;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(556, 609);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 65);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reset Form";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.lblCrustType);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.lblTopping);
            this.groupBox5.Controls.Add(this.lblOrdrerPrise2);
            this.groupBox5.Controls.Add(this.lblWhereEat);
            this.groupBox5.Controls.Add(this.lblSize);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(751, 96);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(445, 448);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order Summary";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Consolas", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.ForeColor = System.Drawing.Color.Red;
            this.lblCrustType.Location = new System.Drawing.Point(228, 341);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(35, 37);
            this.lblCrustType.TabIndex = 9;
            this.lblCrustType.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 45);
            this.label5.TabIndex = 8;
            this.label5.Text = "Crust Type :";
            // 
            // lblTopping
            // 
            this.lblTopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTopping.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopping.Location = new System.Drawing.Point(31, 188);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(351, 101);
            this.lblTopping.TabIndex = 7;
            this.lblTopping.Text = "No Topping";
            // 
            // lblOrdrerPrise2
            // 
            this.lblOrdrerPrise2.AutoSize = true;
            this.lblOrdrerPrise2.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdrerPrise2.Location = new System.Drawing.Point(233, 395);
            this.lblOrdrerPrise2.Name = "lblOrdrerPrise2";
            this.lblOrdrerPrise2.Size = new System.Drawing.Size(30, 33);
            this.lblOrdrerPrise2.TabIndex = 6;
            this.lblOrdrerPrise2.Text = "0";
            // 
            // lblWhereEat
            // 
            this.lblWhereEat.AutoSize = true;
            this.lblWhereEat.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereEat.Location = new System.Drawing.Point(264, 295);
            this.lblWhereEat.Name = "lblWhereEat";
            this.lblWhereEat.Size = new System.Drawing.Size(30, 33);
            this.lblWhereEat.TabIndex = 5;
            this.lblWhereEat.Text = "m";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(122, 75);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 33);
            this.lblSize.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wher To Eat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Topping :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size :";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalPrice.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lbTotalPrice.Location = new System.Drawing.Point(21, 557);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(237, 170);
            this.lbTotalPrice.TabIndex = 7;
            this.lbTotalPrice.Tag = "0";
            this.lbTotalPrice.Text = "$50";
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Brown;
            this.guna2NumericUpDown1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2NumericUpDown1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2NumericUpDown1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2NumericUpDown1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2NumericUpDown1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2NumericUpDown1.DisabledState.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.guna2NumericUpDown1.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.guna2NumericUpDown1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2NumericUpDown1.FocusedState.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2NumericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(903, 610);
            this.guna2NumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.ShadowDecoration.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(142, 50);
            this.guna2NumericUpDown1.TabIndex = 8;
            this.guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.UpDownButtonForeColor = System.Drawing.Color.White;
            this.guna2NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guna2NumericUpDown1.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(873, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "How many order";
            // 
            // FormOrderPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaProject2.Properties.Resources.Pizza_Background_Food___Free_photo_on_Pixabay;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1779, 736);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2NumericUpDown1);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOrderPizza";
            this.Text = "FormOrderPizza";
            this.Load += new System.EventHandler(this.FormOrderPizza_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmallSize;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatin;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlves;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushroums;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.Label lblOrdrerPrise2;
        private System.Windows.Forms.Label lblWhereEat;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCrustType;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private System.Windows.Forms.Label label6;
    }
}