using System;
using Microsoft.Xna.Framework;
using SadConsole;
using SadConsole.Controls;
using Timeless_Peach.src.constructs;

//Manages all of the consoles used in the game

namespace Timeless_Peach.src.consoles {
    class ConsoleManager : ContainerConsole {

        static public PlayConsole gameScreen; //The game screen
        public MainMenuConsole mainMenu;
        public CharacterCreate create;
        public EscapeOptionsConsole escape;

        public ConsoleManager() {
            IsVisible = true;
            IsFocused = true;
            mainMenu = new MainMenuConsole("Timeless Peach", this);
            gameScreen = new PlayConsole(this);
            create = new CharacterCreate(this);
            escape = new EscapeOptionsConsole(this);

            Parent = SadConsole.Global.CurrentScreen;
            Children.Add(mainMenu);
        }

        public override void Update(TimeSpan timeElapsed) {
            
            base.Update(timeElapsed);
        }

        public void CreateGame(PlayableConstruct player) {
            gameScreen.AddPlayer(player);
        }

        private void CheckKeyboard() {

        }

        public PlayConsole getGameScreen() {
            return gameScreen;
        }

    }
}
