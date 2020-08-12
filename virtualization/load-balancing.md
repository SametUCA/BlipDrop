# Load Balancing

3 sunucu 1 normal makine kurulur Makine IP : xx.10

Makine IP : xx.11 Makine IP : xx.12 Makine IP : xx.13

İlk Makine domain controller kurulacak -&gt; new forest -&gt; uca.local -&gt; password Tüm makinalarda Firewall kapatılacak ve DC makinasının IP adresi DNS adresleri kısmına yazılacak. 2 ve 3. Makineyi domaine al firewall kapat ve restart at 2.makinaya ISS KUR 3.makinaya ISS KUR

2 ve 3 makinanın ISS ayarlarını ayrı ayrı yap 2.Makinaya network Balancing Kur – Role and Features kısmından kurabilirsin 3.Makinaya network Balancing Kur – Role and Features kısmından kurabilirsin 2.MAKİNA TOOLS -&gt; NETWORK LOAD BALANCİNG -&gt; NEW CLUSTER -&gt; \(2\)KENDİ IP -&gt; 20 Lİ IP VER -&gt; MULTİCAST -&gt; VS2012-WEB01 -&gt;MULTİCAST -&gt; NETWORK -&gt; FİNİSH VV Uygulama ekranında ki cluster ana elamanı sağ tıkla ve 3. Makinanın IP adresini gir. Ana makina -&gt; DNS MANAGER -&gt; FORWARD LOOKUP ZONE -&gt; NEW HOST -&gt; VS2012-WEB01 -&gt; 20 Lİ IP Yİ GİR

