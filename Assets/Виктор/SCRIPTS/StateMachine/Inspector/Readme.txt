Данная утилита не была дописана т.к. не хватило времени на отлаживание.
Суть данной системы замена Hierarchy FSM
Когда у нас есть иерархические автоматы, мы создаем геймобъект папу который хранит state machine.
Его дочерние объекты являются стейтами которые он получает в автоматическом режиме, а у стейтов на том же обьекте что и сам стейт есть транзишионы
Стейт пр ивключение включает все свои транзишионы

Суть данной утилиты было заменить это всё, чтобы у каждого стейта был не геймобъект, а отдельная вкладка в инспекторе.
Выглядить должно было так.
Мы создаем 1 гейобъект со стейт машиной и она автоматически создает снизу в инспекторе пул состояний.
Мы закидываем 1 состояние и автоматически создается вкладка с эти состоянием и все что мы кидаем, любые скрипты и компоненты на этот объект когда открыта эта
вкладка прикрепляется к этой вкладке.
когда мы закидываем второй стейт, то создается еще одна вкладка к которой мы так-же можем прикреплять свои скрипты, транзишионы и тп.
Переключения между вкладками происходит путем нажатия на них в инспекторе.
Когда мы выбираем какую-либо вкладку то страая вкладка прячет все скрипты и компоненты относящиеся к предыдущей вкладке. 
Еще подразумевалась иерархия автоматом путем того, что на стейт(открытую вкладку) можно было бы кинуть еще одну стейт машину которая порадила бы 
такую же систему еще раз только уже в открытой вкладке со своими вкладками.
Так-же думал, что это нужно показывать визуально и такие стейты со стейт машиной имели бы другой цвет или префикс перед названием вкладки.
Название вкладки это название стейта.
