namespace CPU_S
{
    partial class EAX40000004
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
            this.groupBoxEAX40000004 = new System.Windows.Forms.GroupBox();
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.textBoxEAX = new System.Windows.Forms.TextBox();
            this.labelEAX = new System.Windows.Forms.Label();
            this.textBoxEBX = new System.Windows.Forms.TextBox();
            this.textBoxECX = new System.Windows.Forms.TextBox();
            this.textBoxEDX = new System.Windows.Forms.TextBox();
            this.labelEBX = new System.Windows.Forms.Label();
            this.labelECX = new System.Windows.Forms.Label();
            this.labelEDX = new System.Windows.Forms.Label();
            this.groupBoxEAX = new System.Windows.Forms.GroupBox();
            this.groupBoxEDX = new System.Windows.Forms.GroupBox();
            this.groupBoxECX = new System.Windows.Forms.GroupBox();
            this.groupBoxEBX = new System.Windows.Forms.GroupBox();
            this.checkBoxHypercallForAddressSpaceSwitch = new System.Windows.Forms.CheckBox();
            this.checkBoxHypercallForLocalTLBFlush = new System.Windows.Forms.CheckBox();
            this.checkBoxHypercallForRemoteTLBFlush = new System.Windows.Forms.CheckBox();
            this.checkBoxMSRsforAPIC_EOI_ICR_TPR = new System.Windows.Forms.CheckBox();
            this.checkBoxMSRForSystemReset = new System.Windows.Forms.CheckBox();
            this.checkBoxDeprecateAutoEOI = new System.Windows.Forms.CheckBox();
            this.checkBoxReserved_was_x2APIC_MSRs = new System.Windows.Forms.CheckBox();
            this.checkBoxInterruptRemapping = new System.Windows.Forms.CheckBox();
            this.checkBoxDMARemapping = new System.Windows.Forms.CheckBox();
            this.checkBoxRelaxedTimingDisableWatchdogs = new System.Windows.Forms.CheckBox();
            this.checkBoxUseNestedHVUsingEnlightenedVMCSInterfaceSee4000_000Ah = new System.Windows.Forms.CheckBox();
            this.checkBoxUseINTForMBECSystemCalls = new System.Windows.Forms.CheckBox();
            this.checkBoxHVIsNestedWithinAHyperVPartition = new System.Windows.Forms.CheckBox();
            this.checkBoxNewerExProcessorMasksInterface = new System.Windows.Forms.CheckBox();
            this.checkBoxHypercallForSyntheticClusterIpi = new System.Windows.Forms.CheckBox();
            this.checkBoxNoNonArchitecturalCoreSharingAvoidSTIBPOverhead = new System.Windows.Forms.CheckBox();
            this.checkBoxUseCR4PGEToggleToFlushEntireTLBWhenFasterThanHypercall = new System.Windows.Forms.CheckBox();
            this.checkBoxEAX16Reserved = new System.Windows.Forms.CheckBox();
            this.checkBoxUseSyncedTimelineConsumeRootQueryPerformanceCounterBias = new System.Windows.Forms.CheckBox();
            this.textBoxEAX19_31_Reserved = new System.Windows.Forms.TextBox();
            this.labelEAX19_31_Reserved = new System.Windows.Forms.Label();
            this.textBoxRecommendedSpinlockFailureRetries = new System.Windows.Forms.TextBox();
            this.labelRecommendedSpinlockFailureRetries = new System.Windows.Forms.Label();
            this.textBoxImplementedPhysicalAddressBits = new System.Windows.Forms.TextBox();
            this.textBoxECX7_31_Reserved = new System.Windows.Forms.TextBox();
            this.labelImplementedPhysicalAddressBits = new System.Windows.Forms.Label();
            this.labelECX7_31_Reserved = new System.Windows.Forms.Label();
            this.textBoxEDXReserved = new System.Windows.Forms.TextBox();
            this.labelEDXReserved = new System.Windows.Forms.Label();
            this.groupBoxEAX40000004.SuspendLayout();
            this.groupBoxAll.SuspendLayout();
            this.groupBoxEAX.SuspendLayout();
            this.groupBoxEDX.SuspendLayout();
            this.groupBoxECX.SuspendLayout();
            this.groupBoxEBX.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEAX40000004
            // 
            this.groupBoxEAX40000004.Controls.Add(this.groupBoxAll);
            this.groupBoxEAX40000004.Controls.Add(this.groupBoxEAX);
            this.groupBoxEAX40000004.Controls.Add(this.groupBoxEDX);
            this.groupBoxEAX40000004.Controls.Add(this.groupBoxECX);
            this.groupBoxEAX40000004.Controls.Add(this.groupBoxEBX);
            this.groupBoxEAX40000004.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEAX40000004.Name = "groupBoxEAX40000004";
            this.groupBoxEAX40000004.Size = new System.Drawing.Size(776, 714);
            this.groupBoxEAX40000004.TabIndex = 3;
            this.groupBoxEAX40000004.TabStop = false;
            this.groupBoxEAX40000004.Text = "EAX=0x40000004";
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Controls.Add(this.textBoxEAX);
            this.groupBoxAll.Controls.Add(this.labelEAX);
            this.groupBoxAll.Controls.Add(this.textBoxEBX);
            this.groupBoxAll.Controls.Add(this.textBoxECX);
            this.groupBoxAll.Controls.Add(this.textBoxEDX);
            this.groupBoxAll.Controls.Add(this.labelEBX);
            this.groupBoxAll.Controls.Add(this.labelECX);
            this.groupBoxAll.Controls.Add(this.labelEDX);
            this.groupBoxAll.Location = new System.Drawing.Point(6, 19);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Size = new System.Drawing.Size(252, 133);
            this.groupBoxAll.TabIndex = 57;
            this.groupBoxAll.TabStop = false;
            // 
            // textBoxEAX
            // 
            this.textBoxEAX.Location = new System.Drawing.Point(40, 19);
            this.textBoxEAX.Name = "textBoxEAX";
            this.textBoxEAX.Size = new System.Drawing.Size(200, 20);
            this.textBoxEAX.TabIndex = 1;
            // 
            // labelEAX
            // 
            this.labelEAX.AutoSize = true;
            this.labelEAX.Location = new System.Drawing.Point(3, 22);
            this.labelEAX.Name = "labelEAX";
            this.labelEAX.Size = new System.Drawing.Size(31, 13);
            this.labelEAX.TabIndex = 0;
            this.labelEAX.Text = "EAX:";
            // 
            // textBoxEBX
            // 
            this.textBoxEBX.Location = new System.Drawing.Point(40, 45);
            this.textBoxEBX.Name = "textBoxEBX";
            this.textBoxEBX.Size = new System.Drawing.Size(200, 20);
            this.textBoxEBX.TabIndex = 2;
            // 
            // textBoxECX
            // 
            this.textBoxECX.Location = new System.Drawing.Point(40, 71);
            this.textBoxECX.Name = "textBoxECX";
            this.textBoxECX.Size = new System.Drawing.Size(200, 20);
            this.textBoxECX.TabIndex = 3;
            // 
            // textBoxEDX
            // 
            this.textBoxEDX.Location = new System.Drawing.Point(40, 97);
            this.textBoxEDX.Name = "textBoxEDX";
            this.textBoxEDX.Size = new System.Drawing.Size(200, 20);
            this.textBoxEDX.TabIndex = 4;
            // 
            // labelEBX
            // 
            this.labelEBX.AutoSize = true;
            this.labelEBX.Location = new System.Drawing.Point(3, 48);
            this.labelEBX.Name = "labelEBX";
            this.labelEBX.Size = new System.Drawing.Size(31, 13);
            this.labelEBX.TabIndex = 7;
            this.labelEBX.Text = "EBX:";
            // 
            // labelECX
            // 
            this.labelECX.AutoSize = true;
            this.labelECX.Location = new System.Drawing.Point(3, 74);
            this.labelECX.Name = "labelECX";
            this.labelECX.Size = new System.Drawing.Size(31, 13);
            this.labelECX.TabIndex = 8;
            this.labelECX.Text = "ECX:";
            // 
            // labelEDX
            // 
            this.labelEDX.AutoSize = true;
            this.labelEDX.Location = new System.Drawing.Point(3, 100);
            this.labelEDX.Name = "labelEDX";
            this.labelEDX.Size = new System.Drawing.Size(32, 13);
            this.labelEDX.TabIndex = 9;
            this.labelEDX.Text = "EDX:";
            // 
            // groupBoxEAX
            // 
            this.groupBoxEAX.Controls.Add(this.labelEAX19_31_Reserved);
            this.groupBoxEAX.Controls.Add(this.textBoxEAX19_31_Reserved);
            this.groupBoxEAX.Controls.Add(this.checkBoxNoNonArchitecturalCoreSharingAvoidSTIBPOverhead);
            this.groupBoxEAX.Controls.Add(this.checkBoxUseCR4PGEToggleToFlushEntireTLBWhenFasterThanHypercall);
            this.groupBoxEAX.Controls.Add(this.checkBoxEAX16Reserved);
            this.groupBoxEAX.Controls.Add(this.checkBoxUseSyncedTimelineConsumeRootQueryPerformanceCounterBias);
            this.groupBoxEAX.Controls.Add(this.checkBoxUseNestedHVUsingEnlightenedVMCSInterfaceSee4000_000Ah);
            this.groupBoxEAX.Controls.Add(this.checkBoxUseINTForMBECSystemCalls);
            this.groupBoxEAX.Controls.Add(this.checkBoxHVIsNestedWithinAHyperVPartition);
            this.groupBoxEAX.Controls.Add(this.checkBoxNewerExProcessorMasksInterface);
            this.groupBoxEAX.Controls.Add(this.checkBoxHypercallForSyntheticClusterIpi);
            this.groupBoxEAX.Controls.Add(this.checkBoxDeprecateAutoEOI);
            this.groupBoxEAX.Controls.Add(this.checkBoxReserved_was_x2APIC_MSRs);
            this.groupBoxEAX.Controls.Add(this.checkBoxInterruptRemapping);
            this.groupBoxEAX.Controls.Add(this.checkBoxDMARemapping);
            this.groupBoxEAX.Controls.Add(this.checkBoxRelaxedTimingDisableWatchdogs);
            this.groupBoxEAX.Controls.Add(this.checkBoxMSRForSystemReset);
            this.groupBoxEAX.Controls.Add(this.checkBoxMSRsforAPIC_EOI_ICR_TPR);
            this.groupBoxEAX.Controls.Add(this.checkBoxHypercallForRemoteTLBFlush);
            this.groupBoxEAX.Controls.Add(this.checkBoxHypercallForLocalTLBFlush);
            this.groupBoxEAX.Controls.Add(this.checkBoxHypercallForAddressSpaceSwitch);
            this.groupBoxEAX.Location = new System.Drawing.Point(264, 19);
            this.groupBoxEAX.Name = "groupBoxEAX";
            this.groupBoxEAX.Size = new System.Drawing.Size(506, 485);
            this.groupBoxEAX.TabIndex = 56;
            this.groupBoxEAX.TabStop = false;
            this.groupBoxEAX.Text = "EAX";
            // 
            // groupBoxEDX
            // 
            this.groupBoxEDX.Controls.Add(this.labelEDXReserved);
            this.groupBoxEDX.Controls.Add(this.textBoxEDXReserved);
            this.groupBoxEDX.Location = new System.Drawing.Point(264, 646);
            this.groupBoxEDX.Name = "groupBoxEDX";
            this.groupBoxEDX.Size = new System.Drawing.Size(506, 52);
            this.groupBoxEDX.TabIndex = 55;
            this.groupBoxEDX.TabStop = false;
            this.groupBoxEDX.Text = "EDX";
            // 
            // groupBoxECX
            // 
            this.groupBoxECX.Controls.Add(this.labelECX7_31_Reserved);
            this.groupBoxECX.Controls.Add(this.labelImplementedPhysicalAddressBits);
            this.groupBoxECX.Controls.Add(this.textBoxECX7_31_Reserved);
            this.groupBoxECX.Controls.Add(this.textBoxImplementedPhysicalAddressBits);
            this.groupBoxECX.Location = new System.Drawing.Point(264, 568);
            this.groupBoxECX.Name = "groupBoxECX";
            this.groupBoxECX.Size = new System.Drawing.Size(506, 72);
            this.groupBoxECX.TabIndex = 54;
            this.groupBoxECX.TabStop = false;
            this.groupBoxECX.Text = "ECX";
            // 
            // groupBoxEBX
            // 
            this.groupBoxEBX.Controls.Add(this.labelRecommendedSpinlockFailureRetries);
            this.groupBoxEBX.Controls.Add(this.textBoxRecommendedSpinlockFailureRetries);
            this.groupBoxEBX.Location = new System.Drawing.Point(264, 510);
            this.groupBoxEBX.Name = "groupBoxEBX";
            this.groupBoxEBX.Size = new System.Drawing.Size(506, 52);
            this.groupBoxEBX.TabIndex = 53;
            this.groupBoxEBX.TabStop = false;
            this.groupBoxEBX.Text = "EBX";
            // 
            // checkBoxHypercallForAddressSpaceSwitch
            // 
            this.checkBoxHypercallForAddressSpaceSwitch.AutoSize = true;
            this.checkBoxHypercallForAddressSpaceSwitch.Location = new System.Drawing.Point(6, 18);
            this.checkBoxHypercallForAddressSpaceSwitch.Name = "checkBoxHypercallForAddressSpaceSwitch";
            this.checkBoxHypercallForAddressSpaceSwitch.Size = new System.Drawing.Size(205, 17);
            this.checkBoxHypercallForAddressSpaceSwitch.TabIndex = 0;
            this.checkBoxHypercallForAddressSpaceSwitch.Text = "Hypercall for address space switch [0]";
            this.checkBoxHypercallForAddressSpaceSwitch.UseVisualStyleBackColor = true;
            // 
            // checkBoxHypercallForLocalTLBFlush
            // 
            this.checkBoxHypercallForLocalTLBFlush.AutoSize = true;
            this.checkBoxHypercallForLocalTLBFlush.Location = new System.Drawing.Point(6, 41);
            this.checkBoxHypercallForLocalTLBFlush.Name = "checkBoxHypercallForLocalTLBFlush";
            this.checkBoxHypercallForLocalTLBFlush.Size = new System.Drawing.Size(173, 17);
            this.checkBoxHypercallForLocalTLBFlush.TabIndex = 1;
            this.checkBoxHypercallForLocalTLBFlush.Text = "Hypercall for local TLB flush [1]";
            this.checkBoxHypercallForLocalTLBFlush.UseVisualStyleBackColor = true;
            // 
            // checkBoxHypercallForRemoteTLBFlush
            // 
            this.checkBoxHypercallForRemoteTLBFlush.AutoSize = true;
            this.checkBoxHypercallForRemoteTLBFlush.Location = new System.Drawing.Point(6, 64);
            this.checkBoxHypercallForRemoteTLBFlush.Name = "checkBoxHypercallForRemoteTLBFlush";
            this.checkBoxHypercallForRemoteTLBFlush.Size = new System.Drawing.Size(183, 17);
            this.checkBoxHypercallForRemoteTLBFlush.TabIndex = 2;
            this.checkBoxHypercallForRemoteTLBFlush.Text = "Hypercall for remote TLB flush [2]";
            this.checkBoxHypercallForRemoteTLBFlush.UseVisualStyleBackColor = true;
            // 
            // checkBoxMSRsforAPIC_EOI_ICR_TPR
            // 
            this.checkBoxMSRsforAPIC_EOI_ICR_TPR.AutoSize = true;
            this.checkBoxMSRsforAPIC_EOI_ICR_TPR.Location = new System.Drawing.Point(6, 87);
            this.checkBoxMSRsforAPIC_EOI_ICR_TPR.Name = "checkBoxMSRsforAPIC_EOI_ICR_TPR";
            this.checkBoxMSRsforAPIC_EOI_ICR_TPR.Size = new System.Drawing.Size(183, 17);
            this.checkBoxMSRsforAPIC_EOI_ICR_TPR.TabIndex = 3;
            this.checkBoxMSRsforAPIC_EOI_ICR_TPR.Text = "MSRs for APIC EOI/ICR/TPR [3]";
            this.checkBoxMSRsforAPIC_EOI_ICR_TPR.UseVisualStyleBackColor = true;
            // 
            // checkBoxMSRForSystemReset
            // 
            this.checkBoxMSRForSystemReset.AutoSize = true;
            this.checkBoxMSRForSystemReset.Location = new System.Drawing.Point(6, 110);
            this.checkBoxMSRForSystemReset.Name = "checkBoxMSRForSystemReset";
            this.checkBoxMSRForSystemReset.Size = new System.Drawing.Size(141, 17);
            this.checkBoxMSRForSystemReset.TabIndex = 4;
            this.checkBoxMSRForSystemReset.Text = "MSR for system reset [4]";
            this.checkBoxMSRForSystemReset.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeprecateAutoEOI
            // 
            this.checkBoxDeprecateAutoEOI.AutoSize = true;
            this.checkBoxDeprecateAutoEOI.Location = new System.Drawing.Point(6, 225);
            this.checkBoxDeprecateAutoEOI.Name = "checkBoxDeprecateAutoEOI";
            this.checkBoxDeprecateAutoEOI.Size = new System.Drawing.Size(134, 17);
            this.checkBoxDeprecateAutoEOI.TabIndex = 9;
            this.checkBoxDeprecateAutoEOI.Text = "Deprecate AutoEOI [9]";
            this.checkBoxDeprecateAutoEOI.UseVisualStyleBackColor = true;
            // 
            // checkBoxReserved_was_x2APIC_MSRs
            // 
            this.checkBoxReserved_was_x2APIC_MSRs.AutoSize = true;
            this.checkBoxReserved_was_x2APIC_MSRs.Location = new System.Drawing.Point(6, 202);
            this.checkBoxReserved_was_x2APIC_MSRs.Name = "checkBoxReserved_was_x2APIC_MSRs";
            this.checkBoxReserved_was_x2APIC_MSRs.Size = new System.Drawing.Size(188, 17);
            this.checkBoxReserved_was_x2APIC_MSRs.TabIndex = 8;
            this.checkBoxReserved_was_x2APIC_MSRs.Text = "Reserved (was: x2APIC MSRs) [8]";
            this.checkBoxReserved_was_x2APIC_MSRs.UseVisualStyleBackColor = true;
            // 
            // checkBoxInterruptRemapping
            // 
            this.checkBoxInterruptRemapping.AutoSize = true;
            this.checkBoxInterruptRemapping.Location = new System.Drawing.Point(6, 179);
            this.checkBoxInterruptRemapping.Name = "checkBoxInterruptRemapping";
            this.checkBoxInterruptRemapping.Size = new System.Drawing.Size(132, 17);
            this.checkBoxInterruptRemapping.TabIndex = 7;
            this.checkBoxInterruptRemapping.Text = "Interrupt remapping [7]";
            this.checkBoxInterruptRemapping.UseVisualStyleBackColor = true;
            // 
            // checkBoxDMARemapping
            // 
            this.checkBoxDMARemapping.AutoSize = true;
            this.checkBoxDMARemapping.Location = new System.Drawing.Point(6, 156);
            this.checkBoxDMARemapping.Name = "checkBoxDMARemapping";
            this.checkBoxDMARemapping.Size = new System.Drawing.Size(117, 17);
            this.checkBoxDMARemapping.TabIndex = 6;
            this.checkBoxDMARemapping.Text = "DMA remapping [6]";
            this.checkBoxDMARemapping.UseVisualStyleBackColor = true;
            // 
            // checkBoxRelaxedTimingDisableWatchdogs
            // 
            this.checkBoxRelaxedTimingDisableWatchdogs.AutoSize = true;
            this.checkBoxRelaxedTimingDisableWatchdogs.Location = new System.Drawing.Point(6, 133);
            this.checkBoxRelaxedTimingDisableWatchdogs.Name = "checkBoxRelaxedTimingDisableWatchdogs";
            this.checkBoxRelaxedTimingDisableWatchdogs.Size = new System.Drawing.Size(209, 17);
            this.checkBoxRelaxedTimingDisableWatchdogs.TabIndex = 5;
            this.checkBoxRelaxedTimingDisableWatchdogs.Text = "Relaxed timing – disable watchdogs [5]";
            this.checkBoxRelaxedTimingDisableWatchdogs.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseNestedHVUsingEnlightenedVMCSInterfaceSee4000_000Ah
            // 
            this.checkBoxUseNestedHVUsingEnlightenedVMCSInterfaceSee4000_000Ah.AutoSize = true;
            this.checkBoxUseNestedHVUsingEnlightenedVMCSInterfaceSee4000_000Ah.Location = new System.Drawing.Point(6, 340);
            this.checkBoxUseNestedHVUsingEnlightenedVMCSInterfaceSee4000_000Ah.Name = "checkBoxUseNestedHVUsingEnlightenedVMCSInterfaceSee4000_000Ah";
            this.checkBoxUseNestedHVUsingEnlightenedVMCSInterfaceSee4000_000Ah.Size = new System.Drawing.Size(372, 17);
            this.checkBoxUseNestedHVUsingEnlightenedVMCSInterfaceSee4000_000Ah.TabIndex = 14;
            this.checkBoxUseNestedHVUsingEnlightenedVMCSInterfaceSee4000_000Ah.Text = "Use nested HV using enlightened VMCS interface (see 4000_000Ah) [14]";
            this.checkBoxUseNestedHVUsingEnlightenedVMCSInterfaceSee4000_000Ah.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseINTForMBECSystemCalls
            // 
            this.checkBoxUseINTForMBECSystemCalls.AutoSize = true;
            this.checkBoxUseINTForMBECSystemCalls.Location = new System.Drawing.Point(6, 317);
            this.checkBoxUseINTForMBECSystemCalls.Name = "checkBoxUseINTForMBECSystemCalls";
            this.checkBoxUseINTForMBECSystemCalls.Size = new System.Drawing.Size(194, 17);
            this.checkBoxUseINTForMBECSystemCalls.TabIndex = 13;
            this.checkBoxUseINTForMBECSystemCalls.Text = "Use INT for MBEC system calls [13]";
            this.checkBoxUseINTForMBECSystemCalls.UseVisualStyleBackColor = true;
            // 
            // checkBoxHVIsNestedWithinAHyperVPartition
            // 
            this.checkBoxHVIsNestedWithinAHyperVPartition.AutoSize = true;
            this.checkBoxHVIsNestedWithinAHyperVPartition.Location = new System.Drawing.Point(6, 294);
            this.checkBoxHVIsNestedWithinAHyperVPartition.Name = "checkBoxHVIsNestedWithinAHyperVPartition";
            this.checkBoxHVIsNestedWithinAHyperVPartition.Size = new System.Drawing.Size(227, 17);
            this.checkBoxHVIsNestedWithinAHyperVPartition.TabIndex = 12;
            this.checkBoxHVIsNestedWithinAHyperVPartition.Text = "HV is nested within a Hyper-V partition [12]";
            this.checkBoxHVIsNestedWithinAHyperVPartition.UseVisualStyleBackColor = true;
            // 
            // checkBoxNewerExProcessorMasksInterface
            // 
            this.checkBoxNewerExProcessorMasksInterface.AutoSize = true;
            this.checkBoxNewerExProcessorMasksInterface.Location = new System.Drawing.Point(6, 271);
            this.checkBoxNewerExProcessorMasksInterface.Name = "checkBoxNewerExProcessorMasksInterface";
            this.checkBoxNewerExProcessorMasksInterface.Size = new System.Drawing.Size(215, 17);
            this.checkBoxNewerExProcessorMasksInterface.TabIndex = 11;
            this.checkBoxNewerExProcessorMasksInterface.Text = "Newer ExProcessorMasks interface [11]";
            this.checkBoxNewerExProcessorMasksInterface.UseVisualStyleBackColor = true;
            // 
            // checkBoxHypercallForSyntheticClusterIpi
            // 
            this.checkBoxHypercallForSyntheticClusterIpi.AutoSize = true;
            this.checkBoxHypercallForSyntheticClusterIpi.Location = new System.Drawing.Point(6, 248);
            this.checkBoxHypercallForSyntheticClusterIpi.Name = "checkBoxHypercallForSyntheticClusterIpi";
            this.checkBoxHypercallForSyntheticClusterIpi.Size = new System.Drawing.Size(196, 17);
            this.checkBoxHypercallForSyntheticClusterIpi.TabIndex = 10;
            this.checkBoxHypercallForSyntheticClusterIpi.Text = "Hypercall for SyntheticClusterIpi [10]";
            this.checkBoxHypercallForSyntheticClusterIpi.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoNonArchitecturalCoreSharingAvoidSTIBPOverhead
            // 
            this.checkBoxNoNonArchitecturalCoreSharingAvoidSTIBPOverhead.AutoSize = true;
            this.checkBoxNoNonArchitecturalCoreSharingAvoidSTIBPOverhead.Location = new System.Drawing.Point(6, 432);
            this.checkBoxNoNonArchitecturalCoreSharingAvoidSTIBPOverhead.Name = "checkBoxNoNonArchitecturalCoreSharingAvoidSTIBPOverhead";
            this.checkBoxNoNonArchitecturalCoreSharingAvoidSTIBPOverhead.Size = new System.Drawing.Size(315, 17);
            this.checkBoxNoNonArchitecturalCoreSharingAvoidSTIBPOverhead.TabIndex = 18;
            this.checkBoxNoNonArchitecturalCoreSharingAvoidSTIBPOverhead.Text = "NoNonArchitecturalCoreSharing (avoid STIBP overhead) [18]";
            this.checkBoxNoNonArchitecturalCoreSharingAvoidSTIBPOverhead.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseCR4PGEToggleToFlushEntireTLBWhenFasterThanHypercall
            // 
            this.checkBoxUseCR4PGEToggleToFlushEntireTLBWhenFasterThanHypercall.AutoSize = true;
            this.checkBoxUseCR4PGEToggleToFlushEntireTLBWhenFasterThanHypercall.Location = new System.Drawing.Point(6, 409);
            this.checkBoxUseCR4PGEToggleToFlushEntireTLBWhenFasterThanHypercall.Name = "checkBoxUseCR4PGEToggleToFlushEntireTLBWhenFasterThanHypercall";
            this.checkBoxUseCR4PGEToggleToFlushEntireTLBWhenFasterThanHypercall.Size = new System.Drawing.Size(369, 17);
            this.checkBoxUseCR4PGEToggleToFlushEntireTLBWhenFasterThanHypercall.TabIndex = 17;
            this.checkBoxUseCR4PGEToggleToFlushEntireTLBWhenFasterThanHypercall.Text = "Use CR4.PGE toggle to flush entire TLB (when faster than hypercall) [17]";
            this.checkBoxUseCR4PGEToggleToFlushEntireTLBWhenFasterThanHypercall.UseVisualStyleBackColor = true;
            // 
            // checkBoxEAX16Reserved
            // 
            this.checkBoxEAX16Reserved.AutoSize = true;
            this.checkBoxEAX16Reserved.Location = new System.Drawing.Point(6, 386);
            this.checkBoxEAX16Reserved.Name = "checkBoxEAX16Reserved";
            this.checkBoxEAX16Reserved.Size = new System.Drawing.Size(93, 17);
            this.checkBoxEAX16Reserved.TabIndex = 16;
            this.checkBoxEAX16Reserved.Text = "Reserved [16]";
            this.checkBoxEAX16Reserved.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseSyncedTimelineConsumeRootQueryPerformanceCounterBias
            // 
            this.checkBoxUseSyncedTimelineConsumeRootQueryPerformanceCounterBias.AutoSize = true;
            this.checkBoxUseSyncedTimelineConsumeRootQueryPerformanceCounterBias.Location = new System.Drawing.Point(6, 363);
            this.checkBoxUseSyncedTimelineConsumeRootQueryPerformanceCounterBias.Name = "checkBoxUseSyncedTimelineConsumeRootQueryPerformanceCounterBias";
            this.checkBoxUseSyncedTimelineConsumeRootQueryPerformanceCounterBias.Size = new System.Drawing.Size(366, 17);
            this.checkBoxUseSyncedTimelineConsumeRootQueryPerformanceCounterBias.TabIndex = 15;
            this.checkBoxUseSyncedTimelineConsumeRootQueryPerformanceCounterBias.Text = "UseSyncedTimeline – consume root QueryPerformanceCounter bias [15]";
            this.checkBoxUseSyncedTimelineConsumeRootQueryPerformanceCounterBias.UseVisualStyleBackColor = true;
            // 
            // textBoxEAX19_31_Reserved
            // 
            this.textBoxEAX19_31_Reserved.Location = new System.Drawing.Point(400, 455);
            this.textBoxEAX19_31_Reserved.Name = "textBoxEAX19_31_Reserved";
            this.textBoxEAX19_31_Reserved.Size = new System.Drawing.Size(100, 20);
            this.textBoxEAX19_31_Reserved.TabIndex = 19;
            // 
            // labelEAX19_31_Reserved
            // 
            this.labelEAX19_31_Reserved.AutoSize = true;
            this.labelEAX19_31_Reserved.Location = new System.Drawing.Point(3, 458);
            this.labelEAX19_31_Reserved.Name = "labelEAX19_31_Reserved";
            this.labelEAX19_31_Reserved.Size = new System.Drawing.Size(92, 13);
            this.labelEAX19_31_Reserved.TabIndex = 20;
            this.labelEAX19_31_Reserved.Text = "Reserved [19-31]:";
            // 
            // textBoxRecommendedSpinlockFailureRetries
            // 
            this.textBoxRecommendedSpinlockFailureRetries.Location = new System.Drawing.Point(400, 19);
            this.textBoxRecommendedSpinlockFailureRetries.Name = "textBoxRecommendedSpinlockFailureRetries";
            this.textBoxRecommendedSpinlockFailureRetries.Size = new System.Drawing.Size(100, 20);
            this.textBoxRecommendedSpinlockFailureRetries.TabIndex = 0;
            // 
            // labelRecommendedSpinlockFailureRetries
            // 
            this.labelRecommendedSpinlockFailureRetries.AutoSize = true;
            this.labelRecommendedSpinlockFailureRetries.Location = new System.Drawing.Point(6, 22);
            this.labelRecommendedSpinlockFailureRetries.Name = "labelRecommendedSpinlockFailureRetries";
            this.labelRecommendedSpinlockFailureRetries.Size = new System.Drawing.Size(345, 13);
            this.labelRecommendedSpinlockFailureRetries.TabIndex = 1;
            this.labelRecommendedSpinlockFailureRetries.Text = "Recommended spinlock failure retries (FFFF_FFFFh = -1 = never) [0-31]:";
            // 
            // textBoxImplementedPhysicalAddressBits
            // 
            this.textBoxImplementedPhysicalAddressBits.Location = new System.Drawing.Point(400, 19);
            this.textBoxImplementedPhysicalAddressBits.Name = "textBoxImplementedPhysicalAddressBits";
            this.textBoxImplementedPhysicalAddressBits.Size = new System.Drawing.Size(100, 20);
            this.textBoxImplementedPhysicalAddressBits.TabIndex = 0;
            // 
            // textBoxECX7_31_Reserved
            // 
            this.textBoxECX7_31_Reserved.Location = new System.Drawing.Point(400, 45);
            this.textBoxECX7_31_Reserved.Name = "textBoxECX7_31_Reserved";
            this.textBoxECX7_31_Reserved.Size = new System.Drawing.Size(100, 20);
            this.textBoxECX7_31_Reserved.TabIndex = 1;
            // 
            // labelImplementedPhysicalAddressBits
            // 
            this.labelImplementedPhysicalAddressBits.AutoSize = true;
            this.labelImplementedPhysicalAddressBits.Location = new System.Drawing.Point(6, 22);
            this.labelImplementedPhysicalAddressBits.Name = "labelImplementedPhysicalAddressBits";
            this.labelImplementedPhysicalAddressBits.Size = new System.Drawing.Size(188, 13);
            this.labelImplementedPhysicalAddressBits.TabIndex = 2;
            this.labelImplementedPhysicalAddressBits.Text = "ImplementedPhysicalAddressBits [0-6]:";
            // 
            // labelECX7_31_Reserved
            // 
            this.labelECX7_31_Reserved.AutoSize = true;
            this.labelECX7_31_Reserved.Location = new System.Drawing.Point(6, 48);
            this.labelECX7_31_Reserved.Name = "labelECX7_31_Reserved";
            this.labelECX7_31_Reserved.Size = new System.Drawing.Size(86, 13);
            this.labelECX7_31_Reserved.TabIndex = 3;
            this.labelECX7_31_Reserved.Text = "Reserved [7-31]:";
            // 
            // textBoxEDXReserved
            // 
            this.textBoxEDXReserved.Location = new System.Drawing.Point(400, 19);
            this.textBoxEDXReserved.Name = "textBoxEDXReserved";
            this.textBoxEDXReserved.Size = new System.Drawing.Size(100, 20);
            this.textBoxEDXReserved.TabIndex = 0;
            // 
            // labelEDXReserved
            // 
            this.labelEDXReserved.AutoSize = true;
            this.labelEDXReserved.Location = new System.Drawing.Point(6, 22);
            this.labelEDXReserved.Name = "labelEDXReserved";
            this.labelEDXReserved.Size = new System.Drawing.Size(86, 13);
            this.labelEDXReserved.TabIndex = 1;
            this.labelEDXReserved.Text = "Reserved [0-31]:";
            // 
            // EAX40000004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 735);
            this.Controls.Add(this.groupBoxEAX40000004);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EAX40000004";
            this.Text = "EAX=0x40000004: Reserved for Hypervisors - Recommendations";
            this.groupBoxEAX40000004.ResumeLayout(false);
            this.groupBoxAll.ResumeLayout(false);
            this.groupBoxAll.PerformLayout();
            this.groupBoxEAX.ResumeLayout(false);
            this.groupBoxEAX.PerformLayout();
            this.groupBoxEDX.ResumeLayout(false);
            this.groupBoxEDX.PerformLayout();
            this.groupBoxECX.ResumeLayout(false);
            this.groupBoxECX.PerformLayout();
            this.groupBoxEBX.ResumeLayout(false);
            this.groupBoxEBX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEAX40000004;
        private System.Windows.Forms.GroupBox groupBoxEAX;
        private System.Windows.Forms.GroupBox groupBoxEDX;
        private System.Windows.Forms.GroupBox groupBoxECX;
        private System.Windows.Forms.GroupBox groupBoxEBX;
        private System.Windows.Forms.GroupBox groupBoxAll;
        private System.Windows.Forms.TextBox textBoxEAX;
        private System.Windows.Forms.Label labelEAX;
        private System.Windows.Forms.TextBox textBoxEBX;
        private System.Windows.Forms.TextBox textBoxECX;
        private System.Windows.Forms.TextBox textBoxEDX;
        private System.Windows.Forms.Label labelEBX;
        private System.Windows.Forms.Label labelECX;
        private System.Windows.Forms.Label labelEDX;
        private System.Windows.Forms.CheckBox checkBoxNoNonArchitecturalCoreSharingAvoidSTIBPOverhead;
        private System.Windows.Forms.CheckBox checkBoxUseCR4PGEToggleToFlushEntireTLBWhenFasterThanHypercall;
        private System.Windows.Forms.CheckBox checkBoxEAX16Reserved;
        private System.Windows.Forms.CheckBox checkBoxUseSyncedTimelineConsumeRootQueryPerformanceCounterBias;
        private System.Windows.Forms.CheckBox checkBoxUseNestedHVUsingEnlightenedVMCSInterfaceSee4000_000Ah;
        private System.Windows.Forms.CheckBox checkBoxUseINTForMBECSystemCalls;
        private System.Windows.Forms.CheckBox checkBoxHVIsNestedWithinAHyperVPartition;
        private System.Windows.Forms.CheckBox checkBoxNewerExProcessorMasksInterface;
        private System.Windows.Forms.CheckBox checkBoxHypercallForSyntheticClusterIpi;
        private System.Windows.Forms.CheckBox checkBoxDeprecateAutoEOI;
        private System.Windows.Forms.CheckBox checkBoxReserved_was_x2APIC_MSRs;
        private System.Windows.Forms.CheckBox checkBoxInterruptRemapping;
        private System.Windows.Forms.CheckBox checkBoxDMARemapping;
        private System.Windows.Forms.CheckBox checkBoxRelaxedTimingDisableWatchdogs;
        private System.Windows.Forms.CheckBox checkBoxMSRForSystemReset;
        private System.Windows.Forms.CheckBox checkBoxMSRsforAPIC_EOI_ICR_TPR;
        private System.Windows.Forms.CheckBox checkBoxHypercallForRemoteTLBFlush;
        private System.Windows.Forms.CheckBox checkBoxHypercallForLocalTLBFlush;
        private System.Windows.Forms.CheckBox checkBoxHypercallForAddressSpaceSwitch;
        private System.Windows.Forms.Label labelEAX19_31_Reserved;
        private System.Windows.Forms.TextBox textBoxEAX19_31_Reserved;
        private System.Windows.Forms.TextBox textBoxRecommendedSpinlockFailureRetries;
        private System.Windows.Forms.Label labelRecommendedSpinlockFailureRetries;
        private System.Windows.Forms.Label labelEDXReserved;
        private System.Windows.Forms.TextBox textBoxEDXReserved;
        private System.Windows.Forms.Label labelECX7_31_Reserved;
        private System.Windows.Forms.Label labelImplementedPhysicalAddressBits;
        private System.Windows.Forms.TextBox textBoxECX7_31_Reserved;
        private System.Windows.Forms.TextBox textBoxImplementedPhysicalAddressBits;
    }
}