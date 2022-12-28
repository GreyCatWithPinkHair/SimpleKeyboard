using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Sanford.Multimedia.Midi;

namespace SimpleKeyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void C3_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 48,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void Csh3_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 49,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void D3_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 50,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void Dsh3_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 51,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void E3_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 52,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void F3_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 53,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void Fsh3_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 54,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void G3_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 55,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void Gsh3_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 56,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 57,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void Ash3_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 58,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 59,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void C4_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 60,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void Csh4_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 61,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void D4_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 62,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void Dsh4_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 63,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void E4_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 64,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void F4_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 65,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void Fsh4_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 66,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void G4_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 67,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void Gsh4_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 68,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void A4_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 69,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void Ash4_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 70,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 71,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }

        private void C5_Click(object sender, RoutedEventArgs e)
        {
            using var outDevice = new OutputDevice(0);
            var pitch = new ChannelMessageBuilder
            {
                Command = ChannelCommand.NoteOn,
                MidiChannel = 0,
                Data1 = 72,
                Data2 = 100
            };

            pitch.Build();
            outDevice.Send(pitch.Result);
            Thread.Sleep(1400);

            pitch.Command = ChannelCommand.NoteOff;
            pitch.Data2 = 0;
            pitch.Build();
            outDevice.Send(pitch.Result);
        }
    }
}
