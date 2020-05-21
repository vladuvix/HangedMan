using HangedMan.Core;
using HangedMan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HangedMan.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        GameModel gameModel;
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            gameModel = new GameModel("BUBURUZA");

            var character= gameModel.GetFirstCharacter();

            DisableBtn(character);

            HiddenWord = gameModel.PropertyMaskedWord;

            #region CommandHandler4LetterBtns

            A = new CommandHandler(ABtnMethod, CanExecute);
            B = new CommandHandler(BBtnMethod, CanExecute);
            C = new CommandHandler(CBtnMethod, CanExecute);
            D = new CommandHandler(DBtnMethod, CanExecute);
            E = new CommandHandler(EBtnMethod, CanExecute);
            F = new CommandHandler(FBtnMethod, CanExecute);
            G = new CommandHandler(GBtnMethod, CanExecute);
            H = new CommandHandler(HBtnMethod, CanExecute);
            I = new CommandHandler(IBtnMethod, CanExecute);
            J = new CommandHandler(JBtnMethod, CanExecute);
            K = new CommandHandler(KBtnMethod, CanExecute);
            L = new CommandHandler(LBtnMethod, CanExecute);
            M = new CommandHandler(MBtnMethod, CanExecute);
            N = new CommandHandler(NBtnMethod, CanExecute);
            O = new CommandHandler(OBtnMethod, CanExecute);
            P = new CommandHandler(PBtnMethod, CanExecute);
            Q = new CommandHandler(QBtnMethod, CanExecute);
            R = new CommandHandler(RBtnMethod, CanExecute);
            S = new CommandHandler(SBtnMethod, CanExecute);
            T = new CommandHandler(TBtnMethod, CanExecute);
            U = new CommandHandler(UBtnMethod, CanExecute);
            V = new CommandHandler(VBtnMethod, CanExecute);
            W = new CommandHandler(WBtnMethod, CanExecute);
            X = new CommandHandler(XBtnMethod, CanExecute);
            Y = new CommandHandler(YBtnMethod, CanExecute);
            Z = new CommandHandler(ZBtnMethod, CanExecute);

            #endregion CommandHandler4LetterBtns

            ExitButton = new CommandHandler(ExitBtnMethod, CanExecute);

            NewGameButton = new CommandHandler(NewGameBtnMethod, CanExecute);


        }


        private bool CanExecute()
        {
            return true;
        }

        #region ICommandANDIsEnabled4LettersBtns

        public string HiddenWord { get; set; }

        public ICommand A { get; set; }
        public bool IsAEnabled { get; set; } = true;
        public ICommand B { get; set; }
        public bool IsBEnabled { get; set; } = true;
        public ICommand C { get; set; }
        public bool IsCEnabled { get; set; } = true;
        public ICommand D { get; set; }
        public bool IsDEnabled { get; set; } = true;
        public ICommand E { get; set; }
        public bool IsEEnabled { get; set; } = true;
        public ICommand F { get; set; }
        public bool IsFEnabled { get; set; } = true;
        public ICommand G { get; set; }
        public bool IsGEnabled { get; set; } = true;
        public ICommand H { get; set; }
        public bool IsHEnabled { get; set; } = true;
        public ICommand I { get; set; }
        public bool IsIEnabled { get; set; } = true;
        public ICommand J { get; set; }
        public bool IsJEnabled { get; set; } = true;
        public ICommand K { get; set; }
        public bool IsKEnabled { get; set; } = true;
        public ICommand L { get; set; }
        public bool IsLEnabled { get; set; } = true;
        public ICommand M { get; set; }
        public bool IsMEnabled { get; set; } = true;
        public ICommand N { get; set; }
        public bool IsNEnabled { get; set; } = true;
        public ICommand O { get; set; }
        public bool IsOEnabled { get; set; } = true;
        public ICommand P { get; set; }
        public bool IsPEnabled { get; set; } = true;
        public ICommand Q { get; set; }
        public bool IsQEnabled { get; set; } = true;
        public ICommand R { get; set; }
        public bool IsREnabled { get; set; } = true;
        public ICommand S { get; set; }
        public bool IsSEnabled { get; set; } = true;
        public ICommand T { get; set; }
        public bool IsTEnabled { get; set; } = true;
        public ICommand U { get; set; }
        public bool IsUEnabled { get; set; } = true;
        public ICommand V { get; set; }
        public bool IsVEnabled { get; set; } = true;
        public ICommand W { get; set; }
        public bool IsWEnabled { get; set; } = true;
        public ICommand X { get; set; }
        public bool IsXEnabled { get; set; } = true;
        public ICommand Y { get; set; }
        public bool IsYEnabled { get; set; } = true;
        public ICommand Z { get; set; }
        public bool IsZEnabled { get; set; } = true;

        #endregion ICommandANDIsEnabled4LettersBtns

        public ICommand ExitButton { get; set; }

        public ICommand NewGameButton { get; set; }

        #region BtnsLetterMethods

        private void ABtnMethod()
        {
            gameModel.RevealCharacter('A');
            IsAEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsAEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }

        private void BBtnMethod()
        {
            gameModel.RevealCharacter('B');
            IsBEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsBEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void CBtnMethod()
        {
            gameModel.RevealCharacter('C');
            IsCEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsCEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void DBtnMethod()
        {
            gameModel.RevealCharacter('D');
            IsDEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsDEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void EBtnMethod()
        {
            gameModel.RevealCharacter('E');
            IsEEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsEEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void FBtnMethod()
        {
            gameModel.RevealCharacter('F');
            IsFEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsFEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void GBtnMethod()
        {
            gameModel.RevealCharacter('G');
            IsGEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsGEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void HBtnMethod()
        {
            gameModel.RevealCharacter('H');
            IsHEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsHEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void IBtnMethod()
        {
            gameModel.RevealCharacter('I');
            IsIEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsIEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void JBtnMethod()
        {
            gameModel.RevealCharacter('J');
            IsJEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsJEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void KBtnMethod()
        {
            gameModel.RevealCharacter('K');
            IsKEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsKEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void LBtnMethod()
        {
            gameModel.RevealCharacter('L');
            IsLEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsLEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void MBtnMethod()
        {
            gameModel.RevealCharacter('M');
            IsMEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsMEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void NBtnMethod()
        {
            gameModel.RevealCharacter('N');
            IsNEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsNEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void OBtnMethod()
        {
            gameModel.RevealCharacter('O');
            IsOEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsOEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void PBtnMethod()
        {
            gameModel.RevealCharacter('P');
            IsPEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsPEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void QBtnMethod()
        {
            gameModel.RevealCharacter('Q');
            IsQEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsQEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void RBtnMethod()
        {
            gameModel.RevealCharacter('R');
            IsREnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsREnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void SBtnMethod()
        {
            gameModel.RevealCharacter('S');
            IsSEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsSEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void TBtnMethod()
        {
            gameModel.RevealCharacter('T');
            IsTEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsTEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void UBtnMethod()
        {
            gameModel.RevealCharacter('U');
            IsUEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsUEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void VBtnMethod()
        {
            gameModel.RevealCharacter('V');
            IsVEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsVEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void WBtnMethod()
        {
            gameModel.RevealCharacter('W');
            IsWEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsWEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void XBtnMethod()
        {
            gameModel.RevealCharacter('X');
            IsXEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsXEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void YBtnMethod()
        {
            gameModel.RevealCharacter('Y');
            IsYEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsYEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }
        private void ZBtnMethod()
        {
            gameModel.RevealCharacter('Z');
            IsZEnabled = false;
            HiddenWord = gameModel.PropertyMaskedWord;
            OnPropertyChange(nameof(IsZEnabled));
            OnPropertyChange(nameof(HiddenWord));
        }

        #endregion BtnsLetterMethods


        #region SwitchDisableBtnLetters

        private void DisableBtn( char character)
        {
            switch (character)
            {
                case 'A':
                    IsAEnabled = false;
                    OnPropertyChange(nameof(IsAEnabled));
                    break;
                case 'B':
                    IsBEnabled = false;
                    OnPropertyChange(nameof(IsBEnabled));
                    break;
                case 'C':
                    IsCEnabled = false;
                    OnPropertyChange(nameof(IsCEnabled));
                    break;
                case 'D':
                    IsDEnabled = false;
                    OnPropertyChange(nameof(IsDEnabled));
                    break;
                case 'E':
                    IsEEnabled = false;
                    OnPropertyChange(nameof(IsEEnabled));
                    break;
                case 'F':
                    IsFEnabled = false;
                    OnPropertyChange(nameof(IsFEnabled));
                    break;
                case 'G':
                    IsGEnabled = false;
                    OnPropertyChange(nameof(IsGEnabled));
                    break;
                case 'H':
                    IsHEnabled = false;
                    OnPropertyChange(nameof(IsHEnabled));
                    break;
                case 'I':
                    IsIEnabled = false;
                    OnPropertyChange(nameof(IsIEnabled));
                    break;
                case 'J':
                    IsJEnabled = false;
                    OnPropertyChange(nameof(IsJEnabled));
                    break;
                case 'K':
                    IsKEnabled = false;
                    OnPropertyChange(nameof(IsKEnabled));
                    break;
                case 'L':
                    IsLEnabled = false;
                    OnPropertyChange(nameof(IsLEnabled));
                    break;
                case 'M':
                    IsMEnabled = false;
                    OnPropertyChange(nameof(IsMEnabled));
                    break;
                case 'N':
                    IsNEnabled = false;
                    OnPropertyChange(nameof(IsNEnabled));
                    break;
                case 'O':
                    IsOEnabled = false;
                    OnPropertyChange(nameof(IsOEnabled));
                    break;
                case 'P':
                    IsPEnabled = false;
                    OnPropertyChange(nameof(IsPEnabled));
                    break;
                case 'Q':
                    IsQEnabled = false;
                    OnPropertyChange(nameof(IsQEnabled));
                    break;
                case 'R':
                    IsREnabled = false;
                    OnPropertyChange(nameof(IsREnabled));
                    break;
                case 'S':
                    IsSEnabled = false;
                    OnPropertyChange(nameof(IsSEnabled));
                    break;
                case 'T':
                    IsTEnabled = false;
                    OnPropertyChange(nameof(IsTEnabled));
                    break;
                case 'U':
                    IsUEnabled = false;
                    OnPropertyChange(nameof(IsUEnabled));
                    break;
                case 'V':
                    IsVEnabled = false;
                    OnPropertyChange(nameof(IsVEnabled));
                    break;
                case 'W':
                    IsWEnabled = false;
                    OnPropertyChange(nameof(IsWEnabled));
                    break;
                case 'X':
                    IsXEnabled = false;
                    OnPropertyChange(nameof(IsXEnabled));
                    break;
                case 'Y':
                    IsYEnabled = false;
                    OnPropertyChange(nameof(IsYEnabled));
                    break;
                case 'Z':
                    IsZEnabled = false;
                    OnPropertyChange(nameof(IsZEnabled));
                    break;

            }    

        }
        #endregion SwitchDisableBtnLetters

        #region SwitchEnableBtnLetters

        private void EnableBtn(char character)
        {
            switch (character)
            {
                case 'A':
                    IsAEnabled = true;
                    OnPropertyChange(nameof(IsAEnabled));
                    break;
                case 'B':
                    IsBEnabled = true;
                    OnPropertyChange(nameof(IsBEnabled));
                    break;
                case 'C':
                    IsCEnabled = true;
                    OnPropertyChange(nameof(IsCEnabled));
                    break;
                case 'D':
                    IsDEnabled = true;
                    OnPropertyChange(nameof(IsDEnabled));
                    break;
                case 'E':
                    IsEEnabled = true;
                    OnPropertyChange(nameof(IsEEnabled));
                    break;
                case 'F':
                    IsFEnabled = true;
                    OnPropertyChange(nameof(IsFEnabled));
                    break;
                case 'G':
                    IsGEnabled = true;
                    OnPropertyChange(nameof(IsGEnabled));
                    break;
                case 'H':
                    IsHEnabled = true;
                    OnPropertyChange(nameof(IsHEnabled));
                    break;
                case 'I':
                    IsIEnabled = true;
                    OnPropertyChange(nameof(IsIEnabled));
                    break;
                case 'J':
                    IsJEnabled = true;
                    OnPropertyChange(nameof(IsJEnabled));
                    break;
                case 'K':
                    IsKEnabled = true;
                    OnPropertyChange(nameof(IsKEnabled));
                    break;
                case 'L':
                    IsLEnabled = true;
                    OnPropertyChange(nameof(IsLEnabled));
                    break;
                case 'M':
                    IsMEnabled = true;
                    OnPropertyChange(nameof(IsMEnabled));
                    break;
                case 'N':
                    IsNEnabled = true;
                    OnPropertyChange(nameof(IsNEnabled));
                    break;
                case 'O':
                    IsOEnabled = true;
                    OnPropertyChange(nameof(IsOEnabled));
                    break;
                case 'P':
                    IsPEnabled = true;
                    OnPropertyChange(nameof(IsPEnabled));
                    break;
                case 'Q':
                    IsQEnabled = true;
                    OnPropertyChange(nameof(IsQEnabled));
                    break;
                case 'R':
                    IsREnabled = true;
                    OnPropertyChange(nameof(IsREnabled));
                    break;
                case 'S':
                    IsSEnabled = true;
                    OnPropertyChange(nameof(IsSEnabled));
                    break;
                case 'T':
                    IsTEnabled = true;
                    OnPropertyChange(nameof(IsTEnabled));
                    break;
                case 'U':
                    IsUEnabled = true;
                    OnPropertyChange(nameof(IsUEnabled));
                    break;
                case 'V':
                    IsVEnabled = true;
                    OnPropertyChange(nameof(IsVEnabled));
                    break;
                case 'W':
                    IsWEnabled = true;
                    OnPropertyChange(nameof(IsWEnabled));
                    break;
                case 'X':
                    IsXEnabled = true;
                    OnPropertyChange(nameof(IsXEnabled));
                    break;
                case 'Y':
                    IsYEnabled = true;
                    OnPropertyChange(nameof(IsYEnabled));
                    break;
                case 'Z':
                    IsZEnabled = true;
                    OnPropertyChange(nameof(IsZEnabled));
                    break;

            }

        }
        #endregion SwitchEnableBtnLetters


        private void NewGameBtnMethod()
        {
            //char first = gameModel.GetFirstCharacter();

            //EnableBtn(first);
            List<char> Enablebtnslist = new List<char>() 
            { 'A', 'B','C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 
              'M', 'N', 'O','P','Q','R','S','T','U','V','W','X','Y','Z'};
           
            foreach (char btnlet in Enablebtnslist)
            {
                EnableBtn(btnlet);
            }

            this.gameModel = new GameModel("LILIBAFTOASA");

            var character = gameModel.GetFirstCharacter();

            DisableBtn(character);

            HiddenWord = gameModel.PropertyMaskedWord;

            OnPropertyChange(nameof(HiddenWord));
        }

        private void ExitBtnMethod()
        {
            App.Current.Shutdown();
        }


        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
