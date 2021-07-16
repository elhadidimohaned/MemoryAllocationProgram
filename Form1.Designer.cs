
namespace memory_allocation_program
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.holesNumberBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalMemory = new System.Windows.Forms.TextBox();
            this.numberOfHoles = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.indexOfHole = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.startAdressOfHole = new System.Windows.Forms.TextBox();
            this.indexOfHole1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.holeSize = new System.Windows.Forms.TextBox();
            this.processNumber = new System.Windows.Forms.TextBox();
            this.indexOfProcess = new System.Windows.Forms.Label();
            this.numberOfSegments = new System.Windows.Forms.TextBox();
            this.indexOfSegment = new System.Windows.Forms.Label();
            this.indexOfProcess1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.segmentName = new System.Windows.Forms.TextBox();
            this.segmentSize = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.processindexdeallocation = new System.Windows.Forms.TextBox();
            this.startadressdeallocation = new System.Windows.Forms.TextBox();
            this.programReset = new System.Windows.Forms.Button();
            this.holeAddBTN = new System.Windows.Forms.Button();
            this.ProcessNumberBTN = new System.Windows.Forms.Button();
            this.numberOfSegmentsBTN = new System.Windows.Forms.Button();
            this.segmentAddBTN = new System.Windows.Forms.Button();
            this.resetFields = new System.Windows.Forms.Button();
            this.plot = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.resetFieldsDeallocation = new System.Windows.Forms.Button();
            this.plotDeallocation = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.firstFit = new System.Windows.Forms.RadioButton();
            this.bestFit = new System.Windows.Forms.RadioButton();
            this.worstFit = new System.Windows.Forms.RadioButton();
            this.disableMessages = new System.Windows.Forms.Button();
            this.old = new System.Windows.Forms.RadioButton();
            this.allocated = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(1112, 171);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(353, 662);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::memory_allocation_program.Properties.Resources.Frame;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, -119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1102, 1223);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // holesNumberBTN
            // 
            this.holesNumberBTN.BackColor = System.Drawing.Color.Transparent;
            this.holesNumberBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holesNumberBTN.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.holesNumberBTN.ForeColor = System.Drawing.Color.Red;
            this.holesNumberBTN.Location = new System.Drawing.Point(480, 283);
            this.holesNumberBTN.Name = "holesNumberBTN";
            this.holesNumberBTN.Size = new System.Drawing.Size(92, 47);
            this.holesNumberBTN.TabIndex = 32;
            this.holesNumberBTN.Text = "Add";
            this.holesNumberBTN.UseVisualStyleBackColor = false;
            this.holesNumberBTN.Click += new System.EventHandler(this.holesNumberBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(246, 618);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 37);
            this.label9.TabIndex = 31;
            this.label9.Text = "of Process";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(107, 618);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 37);
            this.label8.TabIndex = 30;
            this.label8.Text = "Segment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(106, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 37);
            this.label7.TabIndex = 29;
            this.label7.Text = "Number of Segments of";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(106, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 37);
            this.label6.TabIndex = 28;
            this.label6.Text = "Number of Process";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(194, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 37);
            this.label5.TabIndex = 27;
            this.label5.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(106, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 37);
            this.label4.TabIndex = 26;
            this.label4.Text = "Hole";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(106, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 37);
            this.label3.TabIndex = 25;
            this.label3.Text = "Number of Holes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "Total Memory Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(286, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 64);
            this.label1.TabIndex = 23;
            this.label1.Text = "Memory Allocation";
            // 
            // totalMemory
            // 
            this.totalMemory.Location = new System.Drawing.Point(354, 237);
            this.totalMemory.Name = "totalMemory";
            this.totalMemory.Size = new System.Drawing.Size(100, 26);
            this.totalMemory.TabIndex = 33;
            this.totalMemory.TextChanged += new System.EventHandler(this.totalMemory_TextChanged);
            // 
            // numberOfHoles
            // 
            this.numberOfHoles.Location = new System.Drawing.Point(354, 293);
            this.numberOfHoles.Name = "numberOfHoles";
            this.numberOfHoles.Size = new System.Drawing.Size(100, 26);
            this.numberOfHoles.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(229, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 35;
            // 
            // indexOfHole
            // 
            this.indexOfHole.AutoSize = true;
            this.indexOfHole.BackColor = System.Drawing.Color.Transparent;
            this.indexOfHole.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.indexOfHole.ForeColor = System.Drawing.Color.White;
            this.indexOfHole.Location = new System.Drawing.Point(162, 349);
            this.indexOfHole.Name = "indexOfHole";
            this.indexOfHole.Size = new System.Drawing.Size(33, 37);
            this.indexOfHole.TabIndex = 36;
            this.indexOfHole.Text = "0";
            this.indexOfHole.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(194, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 37);
            this.label12.TabIndex = 37;
            this.label12.Text = "Start adress";
            // 
            // startAdressOfHole
            // 
            this.startAdressOfHole.Location = new System.Drawing.Point(354, 356);
            this.startAdressOfHole.Name = "startAdressOfHole";
            this.startAdressOfHole.Size = new System.Drawing.Size(100, 26);
            this.startAdressOfHole.TabIndex = 38;
            // 
            // indexOfHole1
            // 
            this.indexOfHole1.AutoSize = true;
            this.indexOfHole1.BackColor = System.Drawing.Color.Transparent;
            this.indexOfHole1.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.indexOfHole1.ForeColor = System.Drawing.Color.White;
            this.indexOfHole1.Location = new System.Drawing.Point(162, 406);
            this.indexOfHole1.Name = "indexOfHole1";
            this.indexOfHole1.Size = new System.Drawing.Size(33, 37);
            this.indexOfHole1.TabIndex = 40;
            this.indexOfHole1.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(106, 406);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 37);
            this.label14.TabIndex = 39;
            this.label14.Text = "Hole";
            // 
            // holeSize
            // 
            this.holeSize.Location = new System.Drawing.Point(354, 413);
            this.holeSize.Name = "holeSize";
            this.holeSize.Size = new System.Drawing.Size(100, 26);
            this.holeSize.TabIndex = 41;
            // 
            // processNumber
            // 
            this.processNumber.Location = new System.Drawing.Point(354, 474);
            this.processNumber.Name = "processNumber";
            this.processNumber.Size = new System.Drawing.Size(100, 26);
            this.processNumber.TabIndex = 43;
            // 
            // indexOfProcess
            // 
            this.indexOfProcess.AutoSize = true;
            this.indexOfProcess.BackColor = System.Drawing.Color.Transparent;
            this.indexOfProcess.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.indexOfProcess.ForeColor = System.Drawing.Color.White;
            this.indexOfProcess.Location = new System.Drawing.Point(312, 572);
            this.indexOfProcess.Name = "indexOfProcess";
            this.indexOfProcess.Size = new System.Drawing.Size(33, 37);
            this.indexOfProcess.TabIndex = 45;
            this.indexOfProcess.Text = "0";
            // 
            // numberOfSegments
            // 
            this.numberOfSegments.Location = new System.Drawing.Point(354, 579);
            this.numberOfSegments.Name = "numberOfSegments";
            this.numberOfSegments.Size = new System.Drawing.Size(100, 26);
            this.numberOfSegments.TabIndex = 46;
            // 
            // indexOfSegment
            // 
            this.indexOfSegment.AutoSize = true;
            this.indexOfSegment.BackColor = System.Drawing.Color.Transparent;
            this.indexOfSegment.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.indexOfSegment.ForeColor = System.Drawing.Color.White;
            this.indexOfSegment.Location = new System.Drawing.Point(215, 618);
            this.indexOfSegment.Name = "indexOfSegment";
            this.indexOfSegment.Size = new System.Drawing.Size(33, 37);
            this.indexOfSegment.TabIndex = 48;
            this.indexOfSegment.Text = "0";
            // 
            // indexOfProcess1
            // 
            this.indexOfProcess1.AutoSize = true;
            this.indexOfProcess1.BackColor = System.Drawing.Color.Transparent;
            this.indexOfProcess1.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.indexOfProcess1.ForeColor = System.Drawing.Color.White;
            this.indexOfProcess1.Location = new System.Drawing.Point(367, 618);
            this.indexOfProcess1.Name = "indexOfProcess1";
            this.indexOfProcess1.Size = new System.Drawing.Size(33, 37);
            this.indexOfProcess1.TabIndex = 49;
            this.indexOfProcess1.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(106, 678);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 37);
            this.label18.TabIndex = 50;
            this.label18.Text = "Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(296, 678);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 37);
            this.label19.TabIndex = 51;
            this.label19.Text = "Size";
            // 
            // segmentName
            // 
            this.segmentName.Location = new System.Drawing.Point(190, 685);
            this.segmentName.Name = "segmentName";
            this.segmentName.Size = new System.Drawing.Size(100, 26);
            this.segmentName.TabIndex = 52;
            // 
            // segmentSize
            // 
            this.segmentSize.Location = new System.Drawing.Point(354, 685);
            this.segmentSize.Name = "segmentSize";
            this.segmentSize.Size = new System.Drawing.Size(100, 26);
            this.segmentSize.TabIndex = 53;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(667, 164);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(322, 64);
            this.label20.TabIndex = 57;
            this.label20.Text = "Deallocation";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(686, 242);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(175, 37);
            this.label21.TabIndex = 58;
            this.label21.Text = "Select Process";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(686, 351);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(175, 37);
            this.label24.TabIndex = 63;
            this.label24.Text = "Process Index";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(686, 411);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(158, 37);
            this.label25.TabIndex = 64;
            this.label25.Text = "Start Adress";
            // 
            // processindexdeallocation
            // 
            this.processindexdeallocation.Location = new System.Drawing.Point(880, 358);
            this.processindexdeallocation.Name = "processindexdeallocation";
            this.processindexdeallocation.Size = new System.Drawing.Size(100, 26);
            this.processindexdeallocation.TabIndex = 65;
            this.processindexdeallocation.TextChanged += new System.EventHandler(this.processindexdeallocation_TextChanged);
            // 
            // startadressdeallocation
            // 
            this.startadressdeallocation.Location = new System.Drawing.Point(880, 416);
            this.startadressdeallocation.Name = "startadressdeallocation";
            this.startadressdeallocation.Size = new System.Drawing.Size(100, 26);
            this.startadressdeallocation.TabIndex = 66;
            this.startadressdeallocation.TextChanged += new System.EventHandler(this.startadressdeallocation_TextChanged);
            // 
            // programReset
            // 
            this.programReset.BackColor = System.Drawing.Color.Transparent;
            this.programReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.programReset.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.programReset.ForeColor = System.Drawing.Color.Red;
            this.programReset.Location = new System.Drawing.Point(727, 561);
            this.programReset.Name = "programReset";
            this.programReset.Size = new System.Drawing.Size(205, 113);
            this.programReset.TabIndex = 69;
            this.programReset.Text = "Reset Program";
            this.programReset.UseVisualStyleBackColor = false;
            this.programReset.Click += new System.EventHandler(this.programReset_Click);
            // 
            // holeAddBTN
            // 
            this.holeAddBTN.BackColor = System.Drawing.Color.Transparent;
            this.holeAddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holeAddBTN.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.holeAddBTN.ForeColor = System.Drawing.Color.Red;
            this.holeAddBTN.Location = new System.Drawing.Point(480, 406);
            this.holeAddBTN.Name = "holeAddBTN";
            this.holeAddBTN.Size = new System.Drawing.Size(92, 47);
            this.holeAddBTN.TabIndex = 70;
            this.holeAddBTN.Text = "Add";
            this.holeAddBTN.UseVisualStyleBackColor = false;
            this.holeAddBTN.Click += new System.EventHandler(this.holeAddBTN_Click);
            // 
            // ProcessNumberBTN
            // 
            this.ProcessNumberBTN.BackColor = System.Drawing.Color.Transparent;
            this.ProcessNumberBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcessNumberBTN.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ProcessNumberBTN.ForeColor = System.Drawing.Color.Red;
            this.ProcessNumberBTN.Location = new System.Drawing.Point(480, 472);
            this.ProcessNumberBTN.Name = "ProcessNumberBTN";
            this.ProcessNumberBTN.Size = new System.Drawing.Size(92, 47);
            this.ProcessNumberBTN.TabIndex = 71;
            this.ProcessNumberBTN.Text = "Add";
            this.ProcessNumberBTN.UseVisualStyleBackColor = false;
            this.ProcessNumberBTN.Click += new System.EventHandler(this.ProcessNumberBTN_Click);
            // 
            // numberOfSegmentsBTN
            // 
            this.numberOfSegmentsBTN.BackColor = System.Drawing.Color.Transparent;
            this.numberOfSegmentsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberOfSegmentsBTN.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.numberOfSegmentsBTN.ForeColor = System.Drawing.Color.Red;
            this.numberOfSegmentsBTN.Location = new System.Drawing.Point(480, 562);
            this.numberOfSegmentsBTN.Name = "numberOfSegmentsBTN";
            this.numberOfSegmentsBTN.Size = new System.Drawing.Size(92, 47);
            this.numberOfSegmentsBTN.TabIndex = 72;
            this.numberOfSegmentsBTN.Text = "Add";
            this.numberOfSegmentsBTN.UseVisualStyleBackColor = false;
            this.numberOfSegmentsBTN.Click += new System.EventHandler(this.numberOfSegmentsBTN_Click);
            // 
            // segmentAddBTN
            // 
            this.segmentAddBTN.BackColor = System.Drawing.Color.Transparent;
            this.segmentAddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.segmentAddBTN.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.segmentAddBTN.ForeColor = System.Drawing.Color.Red;
            this.segmentAddBTN.Location = new System.Drawing.Point(480, 671);
            this.segmentAddBTN.Name = "segmentAddBTN";
            this.segmentAddBTN.Size = new System.Drawing.Size(92, 47);
            this.segmentAddBTN.TabIndex = 73;
            this.segmentAddBTN.Text = "Add";
            this.segmentAddBTN.UseVisualStyleBackColor = false;
            this.segmentAddBTN.Click += new System.EventHandler(this.segmentAddBTN_Click);
            // 
            // resetFields
            // 
            this.resetFields.BackColor = System.Drawing.Color.Transparent;
            this.resetFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetFields.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.resetFields.ForeColor = System.Drawing.Color.Red;
            this.resetFields.Location = new System.Drawing.Point(253, 747);
            this.resetFields.Name = "resetFields";
            this.resetFields.Size = new System.Drawing.Size(201, 47);
            this.resetFields.TabIndex = 75;
            this.resetFields.Text = "Reset Fields";
            this.resetFields.UseVisualStyleBackColor = false;
            this.resetFields.Click += new System.EventHandler(this.resetFields_Click);
            // 
            // plot
            // 
            this.plot.BackColor = System.Drawing.Color.Transparent;
            this.plot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plot.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.plot.ForeColor = System.Drawing.Color.Red;
            this.plot.Location = new System.Drawing.Point(144, 747);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(92, 47);
            this.plot.TabIndex = 74;
            this.plot.Text = "Plot";
            this.plot.UseVisualStyleBackColor = false;
            this.plot.Click += new System.EventHandler(this.plot_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(216, 572);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 37);
            this.label26.TabIndex = 76;
            this.label26.Text = "Process";
            // 
            // resetFieldsDeallocation
            // 
            this.resetFieldsDeallocation.BackColor = System.Drawing.Color.Transparent;
            this.resetFieldsDeallocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetFieldsDeallocation.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.resetFieldsDeallocation.ForeColor = System.Drawing.Color.Red;
            this.resetFieldsDeallocation.Location = new System.Drawing.Point(797, 464);
            this.resetFieldsDeallocation.Name = "resetFieldsDeallocation";
            this.resetFieldsDeallocation.Size = new System.Drawing.Size(201, 47);
            this.resetFieldsDeallocation.TabIndex = 78;
            this.resetFieldsDeallocation.Text = "Reset Fields";
            this.resetFieldsDeallocation.UseVisualStyleBackColor = false;
            this.resetFieldsDeallocation.Click += new System.EventHandler(this.resetFieldsDeallocation_Click);
            // 
            // plotDeallocation
            // 
            this.plotDeallocation.BackColor = System.Drawing.Color.Transparent;
            this.plotDeallocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plotDeallocation.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.plotDeallocation.ForeColor = System.Drawing.Color.Red;
            this.plotDeallocation.Location = new System.Drawing.Point(688, 464);
            this.plotDeallocation.Name = "plotDeallocation";
            this.plotDeallocation.Size = new System.Drawing.Size(92, 47);
            this.plotDeallocation.TabIndex = 77;
            this.plotDeallocation.Text = "Plot";
            this.plotDeallocation.UseVisualStyleBackColor = false;
            this.plotDeallocation.Click += new System.EventHandler(this.plotDeallocation_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(144, 123);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(257, 32);
            this.label27.TabIndex = 79;
            this.label27.Text = "Algorithm Selection";
            // 
            // firstFit
            // 
            this.firstFit.AutoSize = true;
            this.firstFit.BackColor = System.Drawing.Color.Transparent;
            this.firstFit.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.firstFit.ForeColor = System.Drawing.Color.Transparent;
            this.firstFit.Location = new System.Drawing.Point(141, 171);
            this.firstFit.Name = "firstFit";
            this.firstFit.Size = new System.Drawing.Size(137, 41);
            this.firstFit.TabIndex = 86;
            this.firstFit.TabStop = true;
            this.firstFit.Text = "First Fit";
            this.firstFit.UseVisualStyleBackColor = false;
            // 
            // bestFit
            // 
            this.bestFit.AutoSize = true;
            this.bestFit.BackColor = System.Drawing.Color.Transparent;
            this.bestFit.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.bestFit.ForeColor = System.Drawing.Color.Transparent;
            this.bestFit.Location = new System.Drawing.Point(281, 171);
            this.bestFit.Name = "bestFit";
            this.bestFit.Size = new System.Drawing.Size(132, 41);
            this.bestFit.TabIndex = 87;
            this.bestFit.TabStop = true;
            this.bestFit.Text = "Best Fit";
            this.bestFit.UseVisualStyleBackColor = false;
            // 
            // worstFit
            // 
            this.worstFit.AutoSize = true;
            this.worstFit.BackColor = System.Drawing.Color.Transparent;
            this.worstFit.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.worstFit.ForeColor = System.Drawing.Color.Transparent;
            this.worstFit.Location = new System.Drawing.Point(419, 171);
            this.worstFit.Name = "worstFit";
            this.worstFit.Size = new System.Drawing.Size(149, 41);
            this.worstFit.TabIndex = 88;
            this.worstFit.TabStop = true;
            this.worstFit.Text = "Worst Fit";
            this.worstFit.UseVisualStyleBackColor = false;
            // 
            // disableMessages
            // 
            this.disableMessages.BackColor = System.Drawing.Color.Transparent;
            this.disableMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disableMessages.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.disableMessages.ForeColor = System.Drawing.Color.Red;
            this.disableMessages.Location = new System.Drawing.Point(480, 737);
            this.disableMessages.Name = "disableMessages";
            this.disableMessages.Size = new System.Drawing.Size(263, 47);
            this.disableMessages.TabIndex = 89;
            this.disableMessages.Text = "Disable Messages?";
            this.disableMessages.UseVisualStyleBackColor = false;
            this.disableMessages.Click += new System.EventHandler(this.disableMessages_Click);
            // 
            // old
            // 
            this.old.AutoSize = true;
            this.old.BackColor = System.Drawing.Color.Transparent;
            this.old.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.old.ForeColor = System.Drawing.Color.Transparent;
            this.old.Location = new System.Drawing.Point(880, 293);
            this.old.Name = "old";
            this.old.Size = new System.Drawing.Size(86, 41);
            this.old.TabIndex = 90;
            this.old.TabStop = true;
            this.old.Text = "Old";
            this.old.UseVisualStyleBackColor = false;
            this.old.CheckedChanged += new System.EventHandler(this.old_CheckedChanged);
            // 
            // allocated
            // 
            this.allocated.AutoSize = true;
            this.allocated.BackColor = System.Drawing.Color.Transparent;
            this.allocated.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold);
            this.allocated.ForeColor = System.Drawing.Color.Transparent;
            this.allocated.Location = new System.Drawing.Point(693, 293);
            this.allocated.Name = "allocated";
            this.allocated.Size = new System.Drawing.Size(155, 41);
            this.allocated.TabIndex = 91;
            this.allocated.TabStop = true;
            this.allocated.Text = "Allocated";
            this.allocated.UseVisualStyleBackColor = false;
            this.allocated.CheckedChanged += new System.EventHandler(this.allocated_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1477, 932);
            this.Controls.Add(this.allocated);
            this.Controls.Add(this.old);
            this.Controls.Add(this.disableMessages);
            this.Controls.Add(this.worstFit);
            this.Controls.Add(this.bestFit);
            this.Controls.Add(this.firstFit);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.resetFieldsDeallocation);
            this.Controls.Add(this.plotDeallocation);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.resetFields);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.segmentAddBTN);
            this.Controls.Add(this.numberOfSegmentsBTN);
            this.Controls.Add(this.ProcessNumberBTN);
            this.Controls.Add(this.holeAddBTN);
            this.Controls.Add(this.programReset);
            this.Controls.Add(this.startadressdeallocation);
            this.Controls.Add(this.processindexdeallocation);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.segmentSize);
            this.Controls.Add(this.segmentName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.indexOfProcess1);
            this.Controls.Add(this.indexOfSegment);
            this.Controls.Add(this.numberOfSegments);
            this.Controls.Add(this.indexOfProcess);
            this.Controls.Add(this.processNumber);
            this.Controls.Add(this.holeSize);
            this.Controls.Add(this.indexOfHole1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.startAdressOfHole);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.indexOfHole);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numberOfHoles);
            this.Controls.Add(this.totalMemory);
            this.Controls.Add(this.holesNumberBTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Memory Allocation Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button holesNumberBTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfHoles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label indexOfHole;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox startAdressOfHole;
        private System.Windows.Forms.Label indexOfHole1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox holeSize;
        private System.Windows.Forms.TextBox processNumber;
        private System.Windows.Forms.Label indexOfProcess;
        private System.Windows.Forms.TextBox numberOfSegments;
        private System.Windows.Forms.Label indexOfSegment;
        private System.Windows.Forms.Label indexOfProcess1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox segmentName;
        private System.Windows.Forms.TextBox segmentSize;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox processindexdeallocation;
        private System.Windows.Forms.TextBox startadressdeallocation;
        private System.Windows.Forms.Button programReset;
        private System.Windows.Forms.Button holeAddBTN;
        private System.Windows.Forms.Button ProcessNumberBTN;
        private System.Windows.Forms.Button numberOfSegmentsBTN;
        private System.Windows.Forms.Button segmentAddBTN;
        private System.Windows.Forms.Button resetFields;
        private System.Windows.Forms.Button plot;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button resetFieldsDeallocation;
        private System.Windows.Forms.Button plotDeallocation;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RadioButton firstFit;
        private System.Windows.Forms.RadioButton bestFit;
        private System.Windows.Forms.RadioButton worstFit;
        private System.Windows.Forms.TextBox totalMemory;
        private System.Windows.Forms.Button disableMessages;
        private System.Windows.Forms.RadioButton old;
        private System.Windows.Forms.RadioButton allocated;
    }
}

