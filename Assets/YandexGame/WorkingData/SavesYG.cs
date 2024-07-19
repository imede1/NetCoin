
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        // Тестовые сохранения для демо сцены
        // Можно удалить этот код, но тогда удалите и демо (папка Example)                     // Можно задать полям значения по умолчанию
        public string newPlayerName = "Hello!";
        public bool[] openLevels = new bool[3];
        
        public int money = 0;
        public int boost=0;
        public int click=1;
        public bool shopclick_1=false;
        public bool shopclick_2=false;
        public bool shopclick_3=false;
        public bool shopclick_4=false;
        public bool shopclick_5=false;
        public bool shopBoost_1=false;
        public bool shopBoost_2=false;
        public bool shopBoost_3=false;
        public bool shopBoost_4=false;
        public bool shopBoost_5=false;
        

        // Ваши сохранения

        // ...

        // Поля (сохранения) можно удалять и создавать новые. При обновлении игры сохранения ломаться не должны


        // Вы можете выполнить какие то действия при загрузке сохранений
        public SavesYG()
        {
            // Допустим, задать значения по умолчанию для отдельных элементов массива

            openLevels[1] = true;
        }
    }
}
