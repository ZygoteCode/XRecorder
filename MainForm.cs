using MetroSuite;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Collections.Generic;

public partial class MainForm : MetroForm
{
    // Initialize all lists
    private List<Tuple<int, GunaLineTextBox>> outputDevices, inputDevices;
    private List<WasapiLoopbackCapture> outputWaves = new List<WasapiLoopbackCapture>();
    private List<WaveFileWriter> outputWriters = new List<WaveFileWriter>();
    private List<WaveIn> inputWaves = new List<WaveIn>();
    private List<WaveFileWriter> inputWriters = new List<WaveFileWriter>();

    // Main constructor
    public MainForm()
    {
        InitializeComponent();
        siticoneComboBox8.SelectedIndex = 0;
        CheckForIllegalCrossThreadCalls = false;
        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime;

        outputDevices = new List<Tuple<int, GunaLineTextBox>>();
        inputDevices = new List<Tuple<int, GunaLineTextBox>>();

        // Get all active audio devices.
        var devices = new MMDeviceEnumerator().EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
        // Add elements to the output devices panel.
        int currentY = 31;

        for (int i = 0; i < devices.Count; i++)
        {
            MetroLabel label = new MetroLabel();
            label.Text = devices[i].ToString();
            label.Location = new System.Drawing.Point(77, currentY);
            label.Size = new System.Drawing.Size(187, 15);
            panel2.Controls.Add(label);

            GunaLineTextBox lineTextBox = new GunaLineTextBox();
            lineTextBox.Location = new System.Drawing.Point(301, currentY);
            lineTextBox.Size = new System.Drawing.Size(274, 26);
            lineTextBox.LineSize = 1;
            lineTextBox.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lineTextBox.Animated = true;
            lineTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(0, 122, 204);
            panel2.Controls.Add(lineTextBox);

            GunaGradientButton gradientButton = new GunaGradientButton();
            gradientButton.Location = new System.Drawing.Point(581, currentY);
            gradientButton.Size = new System.Drawing.Size(49, 26);
            gradientButton.Text = "...";
            gradientButton.Image = null;
            gradientButton.TextAlign = HorizontalAlignment.Center;
            gradientButton.Animated = true;
            gradientButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(0, 143, 191);
            gradientButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(0, 91, 153);
            gradientButton.BaseColor1 = System.Drawing.Color.DeepSkyBlue;
            gradientButton.BaseColor2 = System.Drawing.Color.FromArgb(0, 122, 204);

            gradientButton.MouseClick += (s, e) =>
            {
                saveFileDialog1.FileName = "";

                if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                {
                    lineTextBox.Text = saveFileDialog1.FileName;
                }
            };
            panel2.Controls.Add(gradientButton);

            ns1.SiticoneCheckBox checkBox = new ns1.SiticoneCheckBox();
            checkBox.Text = "";
            checkBox.Location = new System.Drawing.Point(26, currentY);
            checkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(0, 122, 204);
            checkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            checkBox.Size = new System.Drawing.Size(15, 14);
            checkBox.Name = $"outputDevice{i}";

            checkBox.CheckedChanged += (s, e) =>
            {
                int deviceNumber = int.Parse(checkBox.Name.Substring("ouputDevice".Length + 1));

                if (checkBox.Checked)
                {
                    bool exists = false;

                    foreach (Tuple<int, GunaLineTextBox> occurrence in outputDevices)
                    {
                        if (occurrence.Item1.Equals(deviceNumber))
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        outputDevices.Add(new Tuple<int, GunaLineTextBox>(deviceNumber, lineTextBox));
                    }
                }
                else
                {
                    foreach (Tuple<int, GunaLineTextBox> occurrence in outputDevices)
                    {
                        if (occurrence.Item1.Equals(deviceNumber))
                        {
                            outputDevices.Remove(occurrence);
                            break;
                        }
                    }
                }
            };

            panel2.Controls.Add(checkBox);
            currentY += 37;
        }

        // Get all active input audio devices.
        devices = new MMDeviceEnumerator().EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
        currentY = 31;
        // And add all the necessary elements to the panel for input devices.

        for (int i = 0; i < devices.Count; i++)
        {
            MetroLabel label = new MetroLabel();
            label.Text = devices[i].ToString();
            label.Location = new System.Drawing.Point(77, currentY);
            label.Size = new System.Drawing.Size(187, 15);
            panel1.Controls.Add(label);

            GunaLineTextBox lineTextBox = new GunaLineTextBox();
            lineTextBox.Location = new System.Drawing.Point(301, currentY);
            lineTextBox.Size = new System.Drawing.Size(274, 26);
            lineTextBox.LineSize = 1;
            lineTextBox.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lineTextBox.Animated = true;
            lineTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(lineTextBox);

            GunaGradientButton gradientButton = new GunaGradientButton();
            gradientButton.Location = new System.Drawing.Point(581, currentY);
            gradientButton.Size = new System.Drawing.Size(49, 26);
            gradientButton.Text = "...";
            gradientButton.Image = null;
            gradientButton.TextAlign = HorizontalAlignment.Center;
            gradientButton.Animated = true;
            gradientButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(0, 143, 191);
            gradientButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(0, 91, 153);
            gradientButton.BaseColor1 = System.Drawing.Color.DeepSkyBlue;
            gradientButton.BaseColor2 = System.Drawing.Color.FromArgb(0, 122, 204);

            gradientButton.MouseClick += (s, e) =>
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Filter = "Wave audio file (*.wav)|*.wav";
                fileDialog.FileName = "";
                fileDialog.Title = "Select your output directory";

                if (fileDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    lineTextBox.Text = fileDialog.FileName;
                }
            };
            panel1.Controls.Add(gradientButton);

            ns1.SiticoneCheckBox checkBox = new ns1.SiticoneCheckBox();
            checkBox.Text = "";
            checkBox.Location = new System.Drawing.Point(26, currentY);
            checkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(0, 122, 204);
            checkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(0, 122, 204);
            checkBox.Size = new System.Drawing.Size(15, 14);
            checkBox.Name = $"inputDevice{i}";

            checkBox.CheckedChanged += (s, e) =>
            {
                int deviceNumber = int.Parse(checkBox.Name.Substring("inputDevice".Length));

                if (checkBox.Checked)
                {
                    bool exists = false;

                    foreach (Tuple<int, GunaLineTextBox> occurrence in inputDevices)
                    {
                        if (occurrence.Item1.Equals(deviceNumber))
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        inputDevices.Add(new Tuple<int, GunaLineTextBox>(deviceNumber, lineTextBox));
                    }
                }
                else
                {
                    foreach (Tuple<int, GunaLineTextBox> occurrence in inputDevices)
                    {
                        if (occurrence.Item1.Equals(deviceNumber))
                        {
                            inputDevices.Remove(occurrence);
                            break;
                        }
                    }
                }
            };

            panel1.Controls.Add(checkBox);
            currentY += 37;
        }
    }

    private void gunaGradientButton3_Click(object sender, EventArgs e)
    {
        saveFileDialog1.FileName = "";

        if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
        {
            gunaLineTextBox1.Text = saveFileDialog1.FileName;
        }
    }

    private void gunaGradientButton4_Click(object sender, EventArgs e)
    {
        saveFileDialog1.FileName = "";

        if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
        {
            gunaLineTextBox2.Text = saveFileDialog1.FileName;
        }
    }

    private void gunaGradientButton1_Click(object sender, EventArgs e)
    {
        gunaGradientButton1.Enabled = false;
        StartRecording();
        gunaGradientButton2.Enabled = true;
    }

    private void gunaGradientButton2_Click(object sender, EventArgs e)
    {
        gunaGradientButton2.Enabled = false;
        StopRecording();
        gunaGradientButton1.Enabled = true;
    }

    private void gunaGradientButton5_Click(object sender, EventArgs e)
    {
        saveFileDialog1.FileName = "";

        if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
        {
            gunaLineTextBox3.Text = saveFileDialog1.FileName;
        }
    }

    public void StartRecording()
    {
        outputWaves.Clear();
        outputWriters.Clear();

        if (siticoneCheckBox1.Checked)
        {
            foreach (Tuple<int, GunaLineTextBox> tuple in outputDevices)
            {
                // Start recording from output device.
                var devices = new MMDeviceEnumerator().EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
                var waveIn = new WasapiLoopbackCapture(devices[tuple.Item1]);
                var writer = new WaveFileWriter(tuple.Item2.Text, waveIn.WaveFormat);
                outputWaves.Add(waveIn);
                outputWriters.Add(writer);

                waveIn.DataAvailable += (s, e) =>
                {
                    writer.Write(e.Buffer, 0, e.BytesRecorded);
                };

                waveIn.StartRecording();
            }
        }

        if (siticoneCheckBox2.Checked)
        {
            foreach (Tuple<int, GunaLineTextBox> tuple in inputDevices)
            {
                // Start recording from input device.
                var devices = new MMDeviceEnumerator().EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
                var waveSource = new WaveIn();
                int waveInDevices = WaveIn.DeviceCount;

                // This is a bit more complicated.
                // We need to grab the real device number of WaveIn comparing the names.
                // In fact, WaveIn names are not full as MMDevice names are.
                for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
                {
                    WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);

                    if (deviceInfo.ProductName.StartsWith(devices[tuple.Item1].ToString()) || devices[tuple.Item1].ToString().StartsWith(deviceInfo.ProductName))
                    {
                        waveSource.DeviceNumber = waveInDevice;
                        break;
                    }
                }

                // You can change those values.
                // 48.000 Hz corresponds to 48 KHz, the classical registration frequency.
                // If you are having problems, change it to 44100.
                waveSource.WaveFormat = new WaveFormat(48000, 1);
                // waveSource.NumberOfBuffers = 3; Having buffering problems? Use this.
                var waveFile = new WaveFileWriter(tuple.Item2.Text, waveSource.WaveFormat);
                inputWaves.Add(waveSource);
                inputWriters.Add(waveFile);

                waveSource.DataAvailable += (s, e) =>
                {
                    waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                    waveFile.Flush();
                };

                waveSource.StartRecording();
            }
        }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (gunaGradientButton2.Enabled)
        {
            // Stop the recording after form closing and kill all threads.
            StopRecording();
            Process.GetCurrentProcess().Kill();
        }
    }

    public void StopRecording()
    {
        // To stop recording, we must stop the recording of all the
        // input and the output audio devices.

        foreach (WasapiLoopbackCapture capture in outputWaves)
        {
            // Stop the recording of every audio output device.
            capture.StopRecording();
            // And dispose the element. Garbage Collector will do the rest of work.
            capture.Dispose();
        }

        foreach (WaveFileWriter writer in outputWriters)
        {
            // Close the writer. We don't need it anymore.
            writer.Close();
            // And dispose the element.
            writer.Dispose();
        }

        foreach (WaveIn capture in inputWaves)
        {
            // Stop the recording of every audio input device.
            capture.StopRecording();
            // And dispose the element.
            capture.Dispose();
        }

        foreach (WaveFileWriter writer in inputWriters)
        {
            // Same for the input devices file writers, we don't need them anymore.
            writer.Close();
            // Then, dispose the element.
            writer.Dispose();
        }

        // Clear all elements from the lists.
        // We won't use them anymore, just clear RAM, don't waste it.
        outputWaves.Clear();
        outputWriters.Clear();

        inputWaves.Clear();
        outputWriters.Clear();

        if (siticoneCheckBox7.Checked)
        {
            // This is a bit more complex.
            // We need to mix/merge all the audios of the output devices.
            // To do this, we're using FFMpeg. Don't you have it?
            // Download the Release from GitHub to get "ffmpeg.exe" in your dir.
            string path = gunaLineTextBox3.Text;
            string audioString = "";

            // We need to make a string with all the audio input files for FFMpeg.
            foreach (Tuple<int, GunaLineTextBox> tuple in outputDevices)
            {
                if (audioString == "")
                {
                    audioString = "-i \"" + tuple.Item2.Text + "\"";
                }
                else
                {
                    audioString += " -i \"" + tuple.Item2.Text + "\"";
                }
            }

            // And then let's run FFMpeg for processing.
            Process.Start(new ProcessStartInfo
            {
                FileName = "ffmpeg.exe",
                Arguments = $"{audioString} -filter_complex amix=inputs={outputDevices.Count.ToString()}:duration=longest \"{path}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            }).WaitForExit();
        }
        
        // Same thing we do for input devices.
        if (siticoneCheckBox6.Checked)
        {
            string path = gunaLineTextBox2.Text;
            string audioString = "";

            foreach (Tuple<int, GunaLineTextBox> tuple in inputDevices)
            {
                if (audioString == "")
                {
                    audioString = "-i \"" + tuple.Item2.Text + "\"";
                }
                else
                {
                    audioString += " -i \"" + tuple.Item2.Text + "\"";
                }
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = "ffmpeg.exe",
                Arguments = $"{audioString} -filter_complex amix=inputs={inputDevices.Count.ToString()}:duration=longest \"{path}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            }).WaitForExit();
        }

        // And then for input & output devices.
        if (siticoneCheckBox4.Checked)
        {
            string path = gunaLineTextBox1.Text;
            string audioString = "";

            foreach (Tuple<int, GunaLineTextBox> tuple in inputDevices)
            {
                if (audioString == "")
                {
                    audioString = "-i \"" + tuple.Item2.Text + "\"";
                }
                else
                {
                    audioString += " -i \"" + tuple.Item2.Text + "\"";
                }
            }

            foreach (Tuple<int, GunaLineTextBox> tuple in outputDevices)
            {
                if (audioString == "")
                {
                    audioString = "-i \"" + tuple.Item2.Text + "\"";
                }
                else
                {
                    audioString += " -i \"" + tuple.Item2.Text + "\"";
                }
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = "ffmpeg.exe",
                Arguments = $"{audioString} -filter_complex amix=inputs={(inputDevices.Count + outputDevices.Count).ToString()}:duration=longest \"{path}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            }).WaitForExit();
        }

        if (siticoneCheckBox3.Checked)
        {
            // Delete all files generated from the recording of output devices as requested from the user.
            foreach (Tuple<int, GunaLineTextBox> tuple in outputDevices)
            {
                if (System.IO.File.Exists(tuple.Item2.Text))
                {
                    System.IO.File.Delete(tuple.Item2.Text);
                }
            }
        }

        if (siticoneCheckBox5.Checked)
        {
            // Delete all files generated from the recording of input devices as requested from the user.
            foreach (Tuple<int, GunaLineTextBox> tuple in inputDevices)
            {
                if (System.IO.File.Exists(tuple.Item2.Text))
                {
                    System.IO.File.Delete(tuple.Item2.Text);
                }
            }
        }
    }
}