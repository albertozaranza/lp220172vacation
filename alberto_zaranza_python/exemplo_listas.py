s = 'Aracati, Fortim, Cedro, Fortim'
busca = str(input("Digite o nome de uma cidade: "))

resultado = busca.lower() in s.lower()

if resultado:
    print("A cidade está na lista")
else:
    print("A cidade não está na lista")