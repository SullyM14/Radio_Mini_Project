using System;

namespace RadioApp
{
    public class Radio
    {
        // implement a class Radio that corresponds to the Class diagram 
        //   and specification in the Radio_Mini_Project document
        private int _channel =1;
        private bool _on;
        public int _volume { get; set; }


        public int Channel {
            get { return _channel;}
            set
            {
                if (_on == true)
                {
                    if (value >= 1 && value <= 4)
                    {
                        _channel = value;
                    }
                }
            }
        }

        public Radio()
        {
            //_channel = 1;
            _on = false;
        }
        public string Play()
        {
            if(_on == true)
            {
               // Channel = 4;
                return $"Playing channel {_channel}";
            }
            else
            {
                return $"Radio is off";
            }
        }

        public void TurnOff()
        {
                _on = false;
        }

        public void TurnOn()
        {
                _on = true;

        }

        public void VolumeUp()
        {
            if (_volume <= 100)
            {
                _volume++;
            }
        }

        public void VolumeDown()
        {
            if (_volume >0)
            {
                _volume--;
            }
        }
    }
}