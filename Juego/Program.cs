// See https://aka.ms/new-console-template for more information

class Juego {
    public static void Main() {
        Console.WriteLine("Hola Mundo. Vamos a batallar!");

        Console.WriteLine("Dame la vida del personaje: ");
        int vida = 0;

        do {
            try {
                vida = int.Parse(Console.ReadLine());

                if (vida < 10 || vida > 100) {
                    Console.WriteLine("La vida debe estar entre 10 y 100");
                    continue;
                }

                break;
            } catch {
                Console.WriteLine("Escriba un número");
            }

        } while(true);
        

        Console.WriteLine($"La vida es: {vida}");
    }
}
