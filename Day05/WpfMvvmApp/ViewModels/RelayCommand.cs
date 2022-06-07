using System;
using System.Windows.Input;

namespace WpfMvvmApp.ViewModels
{
    /// <summary>
    /// ViewModel과 View를 Glue하기 위한
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> execute;  //실행처리를 위한 Generic
        private readonly Predicate<T> canExcute;  //실행여부를 판단하는 generic

        //실행여부에 따라서 이벤트를 추가해주거나 삭제하는 이벤트핸들러
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return canExcute?.Invoke((T)parameter) ?? true;
            //throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            execute((T)parameter);
            //throw new NotImplementedException();
        }

        /// <summary>
        /// execute만 파라미터 받는 생성자
        /// </summary>
        /// <param name="execute"></param>
        public RelayCommand(Action<T> execute) : this(execute, null) { }

        /// <summary>
        /// execute, canExecute를 파라미터로 받는 생성자
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExcute"></param>
        public RelayCommand(Action<T> execute, Predicate<T> canExcute = null)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExcute = canExcute;
        }
    }
}
