using System;
using Microsoft.Xna.Framework;
using SadConsole;
using SadConsole.Controls;

//Manages all of the consoles used in the game

namespace Timeless_Peach.src.consoles {
    class ConsoleManager : ContainerConsole {

        public PlayConsole gameScreen; //The game screen
        public MainMenuConsole mainMenu;


        public ConsoleManager() {
            IsVisible = true;
            IsFocused = true;
            mainMenu = new MainMenuConsole("Timeless Peach", this);
            gameScreen = new PlayConsole(this);

            Parent = SadConsole.Global.CurrentScreen;
            Children.Add(mainMenu);
        }

        public override void Update(TimeSpan timeElapsed) {
            
            base.Update(timeElapsed);
        }

        private void CheckKeyboard() {

        }

        public PlayConsole getGameScreen() {
            return gameScreen;
        }

    }
}
