/* 5) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes
   quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada. Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada? */

Primeira ida:
Ligue o interruptor A e deixe-o ligado por 5 minutos para que a lâmpada correspondente aqueça.
Após esse tempo, desligue o interruptor A.
Ligue o interruptor B e vá até a sala das lâmpadas pela primeira vez.
   - A lâmpada que está acesa será controlada pelo interruptor B (que está ligado).
   - A lâmpada que está apagada e quente será controlada pelo interruptor A (que estava ligado e foi desligado).
   - A lâmpada que está apagada e fria será controlada pelo interruptor C (que nunca foi ligado).

Segunda ida:
Para verificar, pode repetir:
Desligue o interruptor B e ligue o interruptor C, depois vá até a sala das lâmpadas novamente.
A lâmpada que estiver acesa agora será a controlada pelo interruptor C, confirmando todas as associações.
