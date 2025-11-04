# 🧩 Actividad 3: Composición vs. Herencia - Modelado de Personajes de Juego

## Contexto

Estás diseñando un sistema de personajes para un videojuego. Un personaje puede atacar y moverse de diferentes maneras. Un guerrero podría atacar con una espada, un mago con un hechizo. Además, algunos personajes podrían ser capaces de volar.

## Tus Tareas

### Parte A - El Problema de la Herencia (Análisis)

* Imagina que comienzas con una clase `Character` y creas subclases como `Warrior` y `Mage`.
* Ahora, necesitas un `FlyingWarrior`. ¿Cómo lo modelarías? ¿Qué pasaría si más adelante necesitas un `Warrior` que también pueda lanzar hechizos?
* **Pregunta:** Escribe 1 o 2 párrafos explicando por qué la herencia se vuelve problemática en este escenario (piensa en explosión de clases o herencia múltiple).

### Parte B - La Solución de Composición (Implementación)

* Refactoriza el diseño usando **"composición sobre herencia"**.
* Crea una clase `Character` que no tenga subclases.
* Crea interfaces para comportamientos, por ejemplo: 
  * `IAttackBehavior` con un método `attack()`
  * `IMovementBehavior` con un método `move()`
* Crea clases concretas para cada comportamiento: 
  * `SwordAttack`
  * `MagicAttack`
  * `WalkingMovement`
  * `FlyingMovement`
* La clase `Character` tendrá una instancia de `IAttackBehavior` y una de `IMovementBehavior`.
* Crea un constructor para `Character` donde puedas "inyectar" los comportamientos deseados.
* Instancia un `FlyingWarrior` creando un `new Character()` y pasándole `new SwordAttack()` y `new FlyingMovement()`.

## Resultado Esperado

Un sistema de personajes flexible donde puedas crear nuevas combinaciones de comportamientos sin modificar la jerarquía de clases, demostrando el poder de la composición.


### Parte A - RESPUESTA

El problema de usar herencia para modelar personajes de juego radica en la "explosión de clases" y la rigidez del diseño. 
Si comenzamos con una clase `Character` y creamos subclases `Warrior` y `Mage`, al necesitar un `FlyingWarrior` nos enfrentamos a varias opciones problemáticas: 
crear una nueva clase `FlyingWarrior` que herede de `Warrior` y duplique la lógica de vuelo, o crear una clase `Flying` de la cual hereden tanto `FlyingWarrior` como `FlyingMage`.
El problema se complica aún más si necesitamos un `SpellCastingWarrior` (guerrero con magia), necesitaríamos otra clase más. 
Con solo 3 tipos de ataque (espada, magia, arco) y 3 tipos de movimiento (caminar, volar, nadar), terminaríamos con 9 combinaciones posibles, lo que significa **9 clases diferentes**.
C# no permite herencia múltiple, por lo que no podemos hacer que `FlyingWarrior` herede simultáneamente de `Warrior` y `Flying`.
Esto nos fuerza a elegir una jerarquía rígida o duplicar código. 
Además, cualquier cambio en el comportamiento de algun acción requeriría modificar múltiples clases (`FlyingWarrior`, `FlyingMage`, etc.). 
Este diseño hace que el código sea difícil de mantener y extender. 
La composición resuelve esto permitiendo que los comportamientos sean objetos independientes que pueden combinarse libremente en tiempo de ejecución.

