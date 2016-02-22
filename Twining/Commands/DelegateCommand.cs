namespace Twining.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    /// <summary>
    /// 実装を委譲できるコマンドを表現します。
    /// </summary>
    public class DelegateCommand : ICommand
    {
        /// <summary>
        /// 現在の状態でこのコマンドを実行できるかどうかを判断するメソッドを定義します。
        /// </summary>
        private Func<object, bool> canExecute;

        /// <summary>
        /// 現在の状態でこのコマンドを実行できるかどうかを判断するメソッドを定義します。
        /// </summary>
        private Action<object> execute;

        /// <summary>
        /// コマンドの起動時に実行するメソッドを指定してインスタンスを生成、初期化します。
        /// </summary>
        /// <param name="execute">コマンドの起動時に実行するメソッド</param>
        public DelegateCommand(Action<object> execute)
            : this(execute, o => true)
        {
        }

        /// <summary>
        /// コマンドの起動時に実行するメソッドとコマンドを実行するかどうかを返すメソッドを指定してインスタンスを生成、初期化します。
        /// </summary>
        /// <param name="execute">コマンドの起動時に実行するメソッド</param>
        /// <param name="canExecute">コマンドを実行するかどうかを返すメソッド</param>
        public DelegateCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// コマンドを実行するかどうかに影響するような変更があった場合に発生します。
        /// </summary>
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

        /// <summary>
        /// 現在の状態でこのコマンドを実行できるかどうかを返します。
        /// </summary>
        /// <param name="parameter">コマンドで使用されたデータ。 コマンドにデータを渡す必要がない場合は、このオブジェクトを null に設定されます。 </param>
        /// <returns>このコマンドを実行できる場合は true。それ以外の場合は false。</returns>
        public bool CanExecute(object parameter)
        {
            return this.canExecute(parameter);
        }

        /// <summary>
        /// コマンドの起動時に呼び出されます。
        /// </summary>
        /// <param name="parameter">コマンドで使用されたデータ。 コマンドにデータを渡す必要がない場合は、このオブジェクトを null に設定されます。</param>
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
