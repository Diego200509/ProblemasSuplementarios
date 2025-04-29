using System;
using System.Timers;


namespace Tic_Tac_Toe.Game
{
    public class GameTimer
    {
        private Timer _timer;
        private int _secondsElapsed;

        // Evento que notifica el tiempo actualizado  
        public event Action<int> TimeUpdated;

        public GameTimer()
        {
            _secondsElapsed = 0;
            _timer = new Timer();
            _timer.Interval = 1000; // 1 segundo  
            _timer.Elapsed += Timer_Elapsed;   
        }

        // Iniciar el temporizador  
        public void Start()
        {
            _secondsElapsed = 0;
            _timer.Start();
        }

        // Detener el temporizador  
        public void Stop()
        {
            _timer.Stop();
        }

        // Evento que se dispara cada segundo  
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _secondsElapsed++;
            TimeUpdated?.Invoke(_secondsElapsed); 
        }
    }
}