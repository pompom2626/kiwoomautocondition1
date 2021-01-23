namespace wikidocsKiwoom1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.setAutoTradingRuleButton = new System.Windows.Forms.Button();
            this.autoTradingStartButton = new System.Windows.Forms.Button();
            this.autoTradingStopButton = new System.Windows.Forms.Button();
            this.SellAllStockButton = new System.Windows.Forms.Button();
            this.stockSearchButton = new System.Windows.Forms.Button();
            this.balanceCheckButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.orderFixButton = new System.Windows.Forms.Button();
            this.orderCancelButton = new System.Windows.Forms.Button();
            this.limitPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.limitNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.balanceDataGridView = new System.Windows.Forms.DataGridView();
            this.outstandingDataGridView = new System.Windows.Forms.DataGridView();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.insertListBox = new System.Windows.Forms.ListBox();
            this.deleteListBox = new System.Windows.Forms.ListBox();
            this.stockCodeLabel = new System.Windows.Forms.Label();
            this.orderPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.orderNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.orderRecordListBox = new System.Windows.Forms.ListBox();
            this.todayProfitLabel = new System.Windows.Forms.Label();
            this.todayProfitRateLabel = new System.Windows.Forms.Label();
            this.totalBuyLabel = new System.Windows.Forms.Label();
            this.totalEstimateLabel = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.autoRuleDataGridView = new System.Windows.Forms.DataGridView();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.limitBuyingPerStockLabel = new System.Windows.Forms.Label();
            this.conditionComboBox = new System.Windows.Forms.ComboBox();
            this.autoBuyOrderComboBox = new System.Windows.Forms.ComboBox();
            this.limitProfitRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.limitLossNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.autoSellOrderComboBox = new System.Windows.Forms.ComboBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.StrategyStocksDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outstandingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoRuleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitProfitRateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitLossNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrategyStocksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(1303, 673);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 48);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // setAutoTradingRuleButton
            // 
            this.setAutoTradingRuleButton.Location = new System.Drawing.Point(22, 25);
            this.setAutoTradingRuleButton.Name = "setAutoTradingRuleButton";
            this.setAutoTradingRuleButton.Size = new System.Drawing.Size(190, 35);
            this.setAutoTradingRuleButton.TabIndex = 1;
            this.setAutoTradingRuleButton.Text = "setAutoTradingRuleButton";
            this.setAutoTradingRuleButton.UseVisualStyleBackColor = true;
            // 
            // autoTradingStartButton
            // 
            this.autoTradingStartButton.Location = new System.Drawing.Point(23, 66);
            this.autoTradingStartButton.Name = "autoTradingStartButton";
            this.autoTradingStartButton.Size = new System.Drawing.Size(189, 30);
            this.autoTradingStartButton.TabIndex = 2;
            this.autoTradingStartButton.Text = "autoTradingStartButton";
            this.autoTradingStartButton.UseVisualStyleBackColor = true;
            // 
            // autoTradingStopButton
            // 
            this.autoTradingStopButton.Location = new System.Drawing.Point(23, 102);
            this.autoTradingStopButton.Name = "autoTradingStopButton";
            this.autoTradingStopButton.Size = new System.Drawing.Size(189, 43);
            this.autoTradingStopButton.TabIndex = 3;
            this.autoTradingStopButton.Text = "autoTradingStopButton";
            this.autoTradingStopButton.UseVisualStyleBackColor = true;
            // 
            // SellAllStockButton
            // 
            this.SellAllStockButton.Location = new System.Drawing.Point(23, 162);
            this.SellAllStockButton.Name = "SellAllStockButton";
            this.SellAllStockButton.Size = new System.Drawing.Size(189, 34);
            this.SellAllStockButton.TabIndex = 4;
            this.SellAllStockButton.Text = "SellAllStockButton";
            this.SellAllStockButton.UseVisualStyleBackColor = true;
            // 
            // stockSearchButton
            // 
            this.stockSearchButton.Location = new System.Drawing.Point(23, 212);
            this.stockSearchButton.Name = "stockSearchButton";
            this.stockSearchButton.Size = new System.Drawing.Size(189, 30);
            this.stockSearchButton.TabIndex = 5;
            this.stockSearchButton.Text = "stockSearchButton";
            this.stockSearchButton.UseVisualStyleBackColor = true;
            // 
            // balanceCheckButton
            // 
            this.balanceCheckButton.Location = new System.Drawing.Point(22, 260);
            this.balanceCheckButton.Name = "balanceCheckButton";
            this.balanceCheckButton.Size = new System.Drawing.Size(190, 30);
            this.balanceCheckButton.TabIndex = 6;
            this.balanceCheckButton.Text = "balanceCheckButton";
            this.balanceCheckButton.UseVisualStyleBackColor = true;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(22, 309);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(152, 32);
            this.buyButton.TabIndex = 7;
            this.buyButton.Text = "buyButton";
            this.buyButton.UseVisualStyleBackColor = true;
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(23, 347);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(151, 38);
            this.sellButton.TabIndex = 8;
            this.sellButton.Text = "sellButton";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // orderFixButton
            // 
            this.orderFixButton.Location = new System.Drawing.Point(22, 391);
            this.orderFixButton.Name = "orderFixButton";
            this.orderFixButton.Size = new System.Drawing.Size(168, 37);
            this.orderFixButton.TabIndex = 9;
            this.orderFixButton.Text = "orderFixButton";
            this.orderFixButton.UseVisualStyleBackColor = true;
            // 
            // orderCancelButton
            // 
            this.orderCancelButton.Location = new System.Drawing.Point(23, 434);
            this.orderCancelButton.Name = "orderCancelButton";
            this.orderCancelButton.Size = new System.Drawing.Size(151, 47);
            this.orderCancelButton.TabIndex = 10;
            this.orderCancelButton.Text = "orderCancelButton";
            this.orderCancelButton.UseVisualStyleBackColor = true;
            // 
            // limitPriceNumericUpDown
            // 
            this.limitPriceNumericUpDown.Location = new System.Drawing.Point(124, 499);
            this.limitPriceNumericUpDown.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.limitPriceNumericUpDown.Name = "limitPriceNumericUpDown";
            this.limitPriceNumericUpDown.Size = new System.Drawing.Size(120, 25);
            this.limitPriceNumericUpDown.TabIndex = 11;
            // 
            // limitNumberNumericUpDown
            // 
            this.limitNumberNumericUpDown.Location = new System.Drawing.Point(124, 540);
            this.limitNumberNumericUpDown.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.limitNumberNumericUpDown.Name = "limitNumberNumericUpDown";
            this.limitNumberNumericUpDown.Size = new System.Drawing.Size(120, 25);
            this.limitNumberNumericUpDown.TabIndex = 12;
            // 
            // balanceDataGridView
            // 
            this.balanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceDataGridView.Location = new System.Drawing.Point(284, 66);
            this.balanceDataGridView.Name = "balanceDataGridView";
            this.balanceDataGridView.RowTemplate.Height = 27;
            this.balanceDataGridView.Size = new System.Drawing.Size(435, 150);
            this.balanceDataGridView.TabIndex = 13;
            // 
            // outstandingDataGridView
            // 
            this.outstandingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outstandingDataGridView.Location = new System.Drawing.Point(754, 66);
            this.outstandingDataGridView.Name = "outstandingDataGridView";
            this.outstandingDataGridView.RowTemplate.Height = 27;
            this.outstandingDataGridView.Size = new System.Drawing.Size(453, 150);
            this.outstandingDataGridView.TabIndex = 14;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(54, 593);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 25);
            this.passwordTextBox.TabIndex = 15;
            // 
            // insertListBox
            // 
            this.insertListBox.FormattingEnabled = true;
            this.insertListBox.ItemHeight = 15;
            this.insertListBox.Location = new System.Drawing.Point(284, 241);
            this.insertListBox.Name = "insertListBox";
            this.insertListBox.Size = new System.Drawing.Size(221, 94);
            this.insertListBox.TabIndex = 16;
            // 
            // deleteListBox
            // 
            this.deleteListBox.FormattingEnabled = true;
            this.deleteListBox.ItemHeight = 15;
            this.deleteListBox.Location = new System.Drawing.Point(522, 241);
            this.deleteListBox.Name = "deleteListBox";
            this.deleteListBox.Size = new System.Drawing.Size(225, 94);
            this.deleteListBox.TabIndex = 17;
            // 
            // stockCodeLabel
            // 
            this.stockCodeLabel.AutoSize = true;
            this.stockCodeLabel.Location = new System.Drawing.Point(22, 630);
            this.stockCodeLabel.Name = "stockCodeLabel";
            this.stockCodeLabel.Size = new System.Drawing.Size(55, 15);
            this.stockCodeLabel.TabIndex = 18;
            this.stockCodeLabel.Text = "005930";
            // 
            // orderPriceNumericUpDown
            // 
            this.orderPriceNumericUpDown.Location = new System.Drawing.Point(124, 658);
            this.orderPriceNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.orderPriceNumericUpDown.Name = "orderPriceNumericUpDown";
            this.orderPriceNumericUpDown.Size = new System.Drawing.Size(120, 25);
            this.orderPriceNumericUpDown.TabIndex = 19;
            // 
            // orderNumberNumericUpDown
            // 
            this.orderNumberNumericUpDown.Location = new System.Drawing.Point(124, 690);
            this.orderNumberNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.orderNumberNumericUpDown.Name = "orderNumberNumericUpDown";
            this.orderNumberNumericUpDown.Size = new System.Drawing.Size(120, 25);
            this.orderNumberNumericUpDown.TabIndex = 20;
            // 
            // orderRecordListBox
            // 
            this.orderRecordListBox.FormattingEnabled = true;
            this.orderRecordListBox.ItemHeight = 15;
            this.orderRecordListBox.Location = new System.Drawing.Point(765, 241);
            this.orderRecordListBox.Name = "orderRecordListBox";
            this.orderRecordListBox.Size = new System.Drawing.Size(217, 94);
            this.orderRecordListBox.TabIndex = 21;
            // 
            // todayProfitLabel
            // 
            this.todayProfitLabel.AutoSize = true;
            this.todayProfitLabel.Location = new System.Drawing.Point(284, 347);
            this.todayProfitLabel.Name = "todayProfitLabel";
            this.todayProfitLabel.Size = new System.Drawing.Size(113, 15);
            this.todayProfitLabel.TabIndex = 22;
            this.todayProfitLabel.Text = "todayProfitLabel";
            // 
            // todayProfitRateLabel
            // 
            this.todayProfitRateLabel.AutoSize = true;
            this.todayProfitRateLabel.Location = new System.Drawing.Point(474, 347);
            this.todayProfitRateLabel.Name = "todayProfitRateLabel";
            this.todayProfitRateLabel.Size = new System.Drawing.Size(143, 15);
            this.todayProfitRateLabel.TabIndex = 23;
            this.todayProfitRateLabel.Text = "todayProfitRateLabel";
            // 
            // totalBuyLabel
            // 
            this.totalBuyLabel.AutoSize = true;
            this.totalBuyLabel.Location = new System.Drawing.Point(672, 347);
            this.totalBuyLabel.Name = "totalBuyLabel";
            this.totalBuyLabel.Size = new System.Drawing.Size(96, 15);
            this.totalBuyLabel.TabIndex = 24;
            this.totalBuyLabel.Text = "totalBuyLabel";
            // 
            // totalEstimateLabel
            // 
            this.totalEstimateLabel.AutoSize = true;
            this.totalEstimateLabel.Location = new System.Drawing.Point(844, 347);
            this.totalEstimateLabel.Name = "totalEstimateLabel";
            this.totalEstimateLabel.Size = new System.Drawing.Size(125, 15);
            this.totalEstimateLabel.TabIndex = 25;
            this.totalEstimateLabel.Text = "totalEstimateLabel";
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Location = new System.Drawing.Point(1005, 347);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(90, 15);
            this.depositLabel.TabIndex = 26;
            this.depositLabel.Text = "depositLabel";
            // 
            // autoRuleDataGridView
            // 
            this.autoRuleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoRuleDataGridView.Location = new System.Drawing.Point(287, 391);
            this.autoRuleDataGridView.Name = "autoRuleDataGridView";
            this.autoRuleDataGridView.RowTemplate.Height = 27;
            this.autoRuleDataGridView.Size = new System.Drawing.Size(432, 150);
            this.autoRuleDataGridView.TabIndex = 27;
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(754, 391);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(121, 23);
            this.accountComboBox.TabIndex = 28;
            // 
            // limitBuyingPerStockLabel
            // 
            this.limitBuyingPerStockLabel.AutoSize = true;
            this.limitBuyingPerStockLabel.Location = new System.Drawing.Point(937, 391);
            this.limitBuyingPerStockLabel.Name = "limitBuyingPerStockLabel";
            this.limitBuyingPerStockLabel.Size = new System.Drawing.Size(111, 15);
            this.limitBuyingPerStockLabel.TabIndex = 29;
            this.limitBuyingPerStockLabel.Text = "limitbuyperstock";
            // 
            // conditionComboBox
            // 
            this.conditionComboBox.FormattingEnabled = true;
            this.conditionComboBox.Location = new System.Drawing.Point(754, 424);
            this.conditionComboBox.Name = "conditionComboBox";
            this.conditionComboBox.Size = new System.Drawing.Size(121, 23);
            this.conditionComboBox.TabIndex = 30;
            // 
            // autoBuyOrderComboBox
            // 
            this.autoBuyOrderComboBox.FormattingEnabled = true;
            this.autoBuyOrderComboBox.Location = new System.Drawing.Point(812, 501);
            this.autoBuyOrderComboBox.Name = "autoBuyOrderComboBox";
            this.autoBuyOrderComboBox.Size = new System.Drawing.Size(121, 23);
            this.autoBuyOrderComboBox.TabIndex = 31;
            // 
            // limitProfitRateNumericUpDown
            // 
            this.limitProfitRateNumericUpDown.Location = new System.Drawing.Point(929, 424);
            this.limitProfitRateNumericUpDown.Name = "limitProfitRateNumericUpDown";
            this.limitProfitRateNumericUpDown.Size = new System.Drawing.Size(120, 25);
            this.limitProfitRateNumericUpDown.TabIndex = 32;
            this.limitProfitRateNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // limitLossNumericUpDown
            // 
            this.limitLossNumericUpDown.Location = new System.Drawing.Point(1129, 424);
            this.limitLossNumericUpDown.Name = "limitLossNumericUpDown";
            this.limitLossNumericUpDown.Size = new System.Drawing.Size(120, 25);
            this.limitLossNumericUpDown.TabIndex = 33;
            // 
            // autoSellOrderComboBox
            // 
            this.autoSellOrderComboBox.FormattingEnabled = true;
            this.autoSellOrderComboBox.Location = new System.Drawing.Point(812, 534);
            this.autoSellOrderComboBox.Name = "autoSellOrderComboBox";
            this.autoSellOrderComboBox.Size = new System.Drawing.Size(121, 23);
            this.autoSellOrderComboBox.TabIndex = 34;
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(793, 460);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(100, 25);
            this.stockTextBox.TabIndex = 35;
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Location = new System.Drawing.Point(812, 563);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(121, 23);
            this.orderComboBox.TabIndex = 36;
            // 
            // StrategyStocksDataGridView
            // 
            this.StrategyStocksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StrategyStocksDataGridView.Location = new System.Drawing.Point(284, 580);
            this.StrategyStocksDataGridView.Name = "StrategyStocksDataGridView";
            this.StrategyStocksDataGridView.RowTemplate.Height = 27;
            this.StrategyStocksDataGridView.Size = new System.Drawing.Size(435, 150);
            this.StrategyStocksDataGridView.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(881, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "이익률";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1071, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "손절률";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "메입제한금액";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "매입제한종목수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "매수거래구분";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(722, 537);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "매도거래구분";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(720, 563);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "거래구분";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(725, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "주식검색";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 658);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "orderprice";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 690);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 47;
            this.label10.Text = "ordernum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 803);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StrategyStocksDataGridView);
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.autoSellOrderComboBox);
            this.Controls.Add(this.limitLossNumericUpDown);
            this.Controls.Add(this.limitProfitRateNumericUpDown);
            this.Controls.Add(this.autoBuyOrderComboBox);
            this.Controls.Add(this.conditionComboBox);
            this.Controls.Add(this.limitBuyingPerStockLabel);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.autoRuleDataGridView);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.totalEstimateLabel);
            this.Controls.Add(this.totalBuyLabel);
            this.Controls.Add(this.todayProfitRateLabel);
            this.Controls.Add(this.todayProfitLabel);
            this.Controls.Add(this.orderRecordListBox);
            this.Controls.Add(this.orderNumberNumericUpDown);
            this.Controls.Add(this.orderPriceNumericUpDown);
            this.Controls.Add(this.stockCodeLabel);
            this.Controls.Add(this.deleteListBox);
            this.Controls.Add(this.insertListBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.outstandingDataGridView);
            this.Controls.Add(this.balanceDataGridView);
            this.Controls.Add(this.limitNumberNumericUpDown);
            this.Controls.Add(this.limitPriceNumericUpDown);
            this.Controls.Add(this.orderCancelButton);
            this.Controls.Add(this.orderFixButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.balanceCheckButton);
            this.Controls.Add(this.stockSearchButton);
            this.Controls.Add(this.SellAllStockButton);
            this.Controls.Add(this.autoTradingStopButton);
            this.Controls.Add(this.autoTradingStartButton);
            this.Controls.Add(this.setAutoTradingRuleButton);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outstandingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoRuleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitProfitRateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitLossNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrategyStocksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Button setAutoTradingRuleButton;
        private System.Windows.Forms.Button autoTradingStartButton;
        private System.Windows.Forms.Button autoTradingStopButton;
        private System.Windows.Forms.Button SellAllStockButton;
        private System.Windows.Forms.Button stockSearchButton;
        private System.Windows.Forms.Button balanceCheckButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button orderFixButton;
        private System.Windows.Forms.Button orderCancelButton;
        private System.Windows.Forms.NumericUpDown limitPriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown limitNumberNumericUpDown;
        private System.Windows.Forms.DataGridView balanceDataGridView;
        private System.Windows.Forms.DataGridView outstandingDataGridView;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ListBox insertListBox;
        private System.Windows.Forms.ListBox deleteListBox;
        private System.Windows.Forms.Label stockCodeLabel;
        private System.Windows.Forms.NumericUpDown orderPriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown orderNumberNumericUpDown;
        private System.Windows.Forms.ListBox orderRecordListBox;
        private System.Windows.Forms.Label todayProfitLabel;
        private System.Windows.Forms.Label todayProfitRateLabel;
        private System.Windows.Forms.Label totalBuyLabel;
        private System.Windows.Forms.Label totalEstimateLabel;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.DataGridView autoRuleDataGridView;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.Label limitBuyingPerStockLabel;
        private System.Windows.Forms.ComboBox conditionComboBox;
        private System.Windows.Forms.ComboBox autoBuyOrderComboBox;
        private System.Windows.Forms.NumericUpDown limitProfitRateNumericUpDown;
        private System.Windows.Forms.NumericUpDown limitLossNumericUpDown;
        private System.Windows.Forms.ComboBox autoSellOrderComboBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.DataGridView StrategyStocksDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

