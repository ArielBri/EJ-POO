using POO_1;
using POO_1.Attacks;
using POO_1.Defenses;
using POO_1.Exporters;
using POO_1.Interfaces;
using POO_1.Movements;
using POO_1.Notifications;

/*EJERCICIO 1*/

Console.WriteLine("╔═══════════════╗");
Console.WriteLine("║ EJERCICIO N°1 ║");
Console.WriteLine("╚═══════════════╝");

// Crear un perfil de usuario
UserProfile user = new UserProfile(
    "juan_perez",
    "juan@example.com",
    "miPassword123"
);

// Mostrar perfil
user.DisplayProfile();
Console.WriteLine();

// Exportar usando JSON
IProfileExporter jsonExporter = new JsonProfileExporter();
jsonExporter.Export(user);
Console.WriteLine();

// Exportar usando XML
IProfileExporter xmlExporter = new XmlProfileExporter();
xmlExporter.Export(user);
Console.WriteLine();


/*EJERCICIO 2*/

Console.WriteLine("╔═══════════════╗");
Console.WriteLine("║ EJERCICIO N°2 ║");
Console.WriteLine("╚═══════════════╝");

//CREANDO SERVICIO NOTIFICACIONES
NotificationService service = new NotificationService();

//CREANDO LISTA DE NOTIFICACIONES
List<Notification> notifications = new List<Notification>();

//AGREGANDO NOTIFICACIONES
notifications.Add(new EmailNotification(
    "juan@gmail.com",
    "Tu pedido ha sido enviado",
    "Confirmación de Pedido"
));

notifications.Add(new SmsNotification(
    "Juan Perez",
    "Tu código de verificación es: 123456",
    "+54 11 1234-5678"
));

notifications.Add(new PushNotification(
    "Carlos López",
    "Tienes un nuevo mensaje",
    "device-android-abc123"
));

notifications.Add(new EmailNotification(
    "ana@gmail.com",
    "Recordatorio: Reunión mañana a las 10:00",
    "Recordatorio de Reunión"
));

notifications.Add(new SmsNotification(
    "Pedro Martínez",
    "Tu reserva ha sido confirmada",
    "+54 11 9876-5432"
));

//ENVIAR TODAS LAS NOTIFICACIONES -  POLIMORFISMO
service.SendBatch(notifications);

// Ejemplo adicional: enviar una notificación individual
Console.WriteLine("--- Ejemplo de notificación individual ---");
Notification urgentNotification = new PushNotification(
    "Admin",
    "¡ALERTA! Actividad sospechosa detectada",
    "device-ios-xyz789"
);

Console.WriteLine("--- Presiona cualquier tecla para continuar ---");
Console.ReadKey();


/*EJERCICIO 3*/

Console.WriteLine(" ");
Console.WriteLine("╔═══════════════╗");
Console.WriteLine("║ EJERCICIO N°3 ║");
Console.WriteLine("╚═══════════════╝");
Console.WriteLine(" ");
Console.WriteLine("╔══════════════════════════════════════════════════╗");
Console.WriteLine("║  SISTEMA DE PERSONAJES - COMPOSICIÓN vs HERENCIA ║");
Console.WriteLine("╚══════════════════════════════════════════════════╝");

// 1. Guerrero Tradicional
Character warrior = new Character(
    "Aragorn el Guerrero",
    new SwordAttack(),
    new WalkingMovement(),
    new ShieldDefense(),
    120,
    5
);

// 2. Mago
Character mage = new Character(
    "Gandalf el Mago",
    new MagicAttack(),
    new WalkingMovement(),
    new MagicBarrierDefense(),
    80,
    7
);

// 3. Guerrero Volador (¡El problema original!)
Character flyingWarrior = new Character(
    "Valkyria la Guerrera Alada",
    new SwordAttack(),
    new FlyingMovement(),
    new DodgeDefense(),
    110,
    6
);

// 4. Arquero Volador
Character flyingArcher = new Character(
    "Legolas el Arquero Aéreo",
    new BowAttack(),
    new FlyingMovement(),
    new DodgeDefense(),
    90,
    5
);

// 5. Mago Guerrero (Spell-casting Warrior)
Character spellblade = new Character(
    "Arthas el Paladín Oscuro",
    new MagicAttack(),
    new WalkingMovement(),
    new ShieldDefense(),
    115,
    8
);

// 6. Ninja Acuático
Character waterNinja = new Character(
    "Mizuki la Ninja del Agua",
    new FistAttack(),
    new SwimmingMovement(),
    new DodgeDefense(),
    95,
    4
);

// 7. Hechicero Teletransportador
Character teleportMage = new Character(
    "Zephyr el Místico",
    new MagicAttack(),
    new TeleportMovement(),
    new MagicBarrierDefense(),
    75,
    10
);

// Lista de todos los personajes
List<Character> characters = new List<Character>
        {
            warrior, mage, flyingWarrior, flyingArcher,
            spellblade, waterNinja, teleportMage
        };

// Demostrar cada personaje
foreach (Character character in characters)
{
    character.DisplayInfo();
    character.PerformCombatSequence();
    Console.WriteLine();
}

// Demostrar cambio de comportamiento en tiempo de ejecución
Console.WriteLine("╔════════════════════════════════════════════════╗");
Console.WriteLine("║     CAMBIO DINÁMICO DE COMPORTAMIENTOS         ║");
Console.WriteLine("╚════════════════════════════════════════════════╝");

warrior.DisplayInfo();
Console.WriteLine("Estado inicial:");
warrior.PerformCombatSequence();

Console.WriteLine("¡Aragorn encuentra un pergamino antiguo y aprende magia!");
warrior.SetAttackBehavior(new MagicAttack());

Console.WriteLine("¡Aragorn encuentra unas alas mágicas!");
warrior.SetMovementBehavior(new FlyingMovement());

Console.WriteLine("Nuevo estado:");
warrior.PerformCombatSequence();

Console.WriteLine("╔════════════════════════════════════════════════╗");
Console.WriteLine("║              VENTAJAS DE COMPOSICIÓN           ║");
Console.WriteLine("╚════════════════════════════════════════════════╝");
Console.WriteLine("* Sin explosión de clases");
Console.WriteLine("* Comportamientos intercambiables en tiempo de ejecución");
Console.WriteLine("* Fácil agregar nuevos comportamientos");
Console.WriteLine("* Combinaciones ilimitadas sin modificar código existente");
Console.WriteLine("* Código más mantenible y flexible");

Console.WriteLine("--- Presiona cualquier tecla para salir ---");
Console.ReadKey();
