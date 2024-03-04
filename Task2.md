# Задание 2: Визуальный эффект лечения

## Описание

В этом задании мы изучим Particle System (система частиц). Эта система используется в Unity, чтобы делать красивые визуальные эффекты. Попробуем сделать два эффекта: свечение бутылки зелья и эффект получения здоровья игроком.

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/result.gif" width="600"/>

## Инструкция

1. Эффект свечения зелья.

Для начала давай импортируем в проект [пакет](https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/M3W9_materials.unitypackage) с двумя материалами для наших эффектов. Материалы лежат в папке Assets/RPG Pack/Materials и называются Glow_particles.mat и Stars_particles.mat

Эти материалы пригодятся нам при создании эффектов.

Создай новый объект в иерархии сцены Effects -> Particle System

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/create_particles.png" width="400"/>

Сделай его дочерним к предмету лечения и обнули его позицию, чтобы он находился ровно в том же месте что и предмет.

Это система частиц. Сейчас она выглядит просто как разлетающиеся белые точки.

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/particles1.png" width="600"/>

Система частиц имеет множество параметров. Посмотри на эти параметры. 

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/Particles.png" width="400"/>

В самом низу находится группа параметров Renderer. Замени материал на Glow_particles из пакета. Это самая главная настройка, она отвечает за то, как будет выглядеть каждая наша частица.

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/Renderer.png" width="400"/>

Теперь наши частицы выглядят вот так

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/particle.png" width="300"/>

Теперь вернемся к началу. Верхние настройки не имеют группы. Настроим общую длительность эффекта, длительность каждой частицы, цвет и начальную скорость частиц. Ты можешь поэкспериментировать с разными значениями этих параметров и посмотреть как это отражается на системе частиц. На скриншоте можно посмотреть пример настроек.

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/particles_settings1.png" width="600"/>

Следующая настройка Emission. Она отвечает за то, как часто будут появляться новые частицы. Выстави Rate over Time 3

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/emission.png" width="600"/>

Теперь настроим область из которой будут появляться новые частицы. За это отвечает группа настроек Shape. Давай сделаем так, чтобы разброс частиц был минимален, поэтому выставим фигуру сферу (Sphere) с маленьким радиусом 0.1

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/shape.png" width="600"/>

Сейчас частицы очень резко появляются и пропадают и это бросается в глаза. Давай настроим Size over Lifetime. Этот параметр позволяет задать размер каждой частицы в каждый момент времени на протяжении всего существования. Задается он с помощью анимационной кривой. Расставь точки кривой вручную или выбери существующий пресет.

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/size_curve.png" width="600"/>

Параметр Rotation over Lifetime позволяет задать скорость вращения частиц. Задай скорость 15 градусов в секунду

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/rotation.png" width="600"/>

Сейчас наш эффект выглядит пример так:

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/effect1.png" width="600"/>

Ты можешь задать параметры по своему вкусу, правильных ответов тут нет, это долгий творческий процесс, перебор возможных значений до тех пор, пока тебе не понравится результат

2. Эффект восстановления здоровья.

Второй эффект будет иметь немного другую структуру. Мы сделаем так, что этот эффект будет воспроизводится только, когда игрок подбирает предмет лечения.

Создай новый объект в сцене Effects -> Particle System

Сделай его дочерним к игроку и помести примерно на уровне живота персонажа

В настройке Render замени материал на второй материал из пака Stars_particles

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/stars_material.png" width="400"/>

В общих настройках измени длительность, скорость, начальный размер частиц, цвет и прочие параметры. Не забудь убрать галочку Play On Awake, чтобы эффект не воспроизводился в начале игры. Simulation Space World позволяет открепить частицы от игрока и двигать их в пространстве независимо.

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/heal_effect_1.png" width="400"/>

В настройках Emission выстави Rate over Time "50", в настройках Shape выстави сферу и радиус примерно "0.5"

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/heal_effect_2.png" width="400"/>

Velocity over Lifetime позволяет нам контроллировать скорость каждой частицы на протяжении ее существования.

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/heal_effect_3.png" width="400"/>

Настройка Noise позволяет добавить некоторую хаотичность в движение частиц.

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/noise.png" width="400"/>

Ну и наконец сделаем так, чтобы за частицей тянулся след. Внутри Trail выставь время жизни следа и сделай его немного прозрачным в параметре Color over Lifetime. Так же уменьши ширину следа.

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/trail.png" width="600"/>

Отлично! Система частиц готова. Осталось только запускать ее при подборе предмета лечения. Для этого надо немного модифицировать скрипт PlayerHealth

Для начала объяви новое поле ссылку на нашу систему частиц

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/script1.png" width="400"/>

Теперь, когда игрок получает лечение, необходимо запустить проигрывание системы частиц. Для этого существует метод Play();

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/script2.png" width="600"/>

Не забудь навесить ссылку на систему частиц

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/ref.png" width="600"/>

Запусти проект, проверь что все работает.

<img src="https://github.com/copetonrob/YP_Unity_M3_W9/blob/main/img/result.gif" width="600"/>

3. Задания со звездочкой.

Попробуй сделать так, чтобы зелье лечения вращалось и/или покачивалось в пространстве.