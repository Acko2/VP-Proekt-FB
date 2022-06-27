# Flapppy Bird

## Проект по визуелно програмирање

Проектната задача е имплементација на веќе постоечката игра FlappyBird. Целта на играчот е да лета со птицата и да поминува низ малите отвори помеѓу две цевки и доколку удри во некоја од цевките или во земјата играта завршува. Играта е бесконечна и целта да се освојат што е можно повеке поени.

Играта е имплементирана така што цевките ги движиме на лево додека птицата е статична во X оската и се движи само горе/доле. Во играта има два тајмери, едниот е главниот тајмер за играта, а другиот  е тајмер за креирање на нови цевки десно надвор од формата преку функцијата mPipes(). Цевките секогаш се креираат на исто растојание една од друга но со користење на Random генераторот одредуваме на која висина ке бидат цевките. Цевките се бришат кога ке излезат лево надвор од формата. За проверка дали птицата допрела во една од цевките или земјата ја користиме x.Bounds.IntersectsWith(y.Bounds) методата. Во случај ако има допир играта завршува преку повикување на gameEnd() функцијата.

Неколку слики од играта

Почеток на ирата:
![pocetok](https://user-images.githubusercontent.com/63553277/175985860-18b35056-7504-42aa-a103-b2a08adfdc2c.png)

Тек на играта:
![tek](https://user-images.githubusercontent.com/63553277/175986153-5bf785af-c590-430a-87b8-5f0fe6a105da.png)

Крај на играта:
![kraj](https://user-images.githubusercontent.com/63553277/175986506-0d72cb0a-6167-4fc2-b58c-5a10cb04671e.png)
