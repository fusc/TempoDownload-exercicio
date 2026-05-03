﻿Console.WriteLine("TEMPO DE DOWNLOAD");

double tamanhoArquivo, velocidadeMbps, tempo;

Console.WriteLine("Tamanho do arquivo em MB...:");
tamanhoArquivo = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine("Velocidade da conexão em Mbps...:");
 velocidadeMbps = Convert.ToDouble(Console.ReadLine());

 tempo = tamanhoArquivo * 8 / velocidadeMbps / 60;

Console.WriteLine($"\nTempo estimado de download: {tempo:N1}minutos");