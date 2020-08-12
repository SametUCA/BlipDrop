# Hyper-V Notlarim



## DİSK GENİŞLETME

Manager altında ki component sağ tıklanır ve edit disk seçeneği ile devam edilir.

Bir sonraki pencerede diskin kendisi seçilir

                COMPACT -&gt; Disk sıkıştırma\(fixed\) minimum ayarlara göre

                CONVERT -&gt; Disk tipini çevir

                EXPAND -&gt; Diski genişletir

                SHRİNK -&gt; Küçültür

Vhd ve Vhdx usb bellek gibi kullanılabilir. Bu dosyalar taşınıp başka bir makinada kullanılabilir.

## VİRTUAL SWİTCH

External bir ethernete connect olur ve ordan çıkar external en az 1 fiziksel ağ kartı gerekir.

Diğer makinelerle iletişime geçeçer

VLAN -&gt; Alt ağ

Kart Yapıları

                Private -&gt; Lab ortamlarında kurulur. Gerek yoktur.

                External -&gt; Dış dünya ile iletişimimizi sağlar

                İnternal -&gt; Sanalların kendi aralarında ki iletişim

##  

## SAN MANAGER

Storage area network

Yani veri depolama üniteleri

Sunucu ßà Storage

Numa -&gt; Araştırılacak

Live Migration -&gt; Bir sunucudan diğer sunucuya aktarma

Storage migration -&gt; Storageleri göç ettirir.

Enhanced Session -&gt; \*\*

Replication Configuration &gt; Çalışır durumdayken yedekle

##  

## CREATE VİRTUAL MACHİNE

Generation 1 -&gt; Tüm platformlarda desteklenir

Generation -&gt; UEFI Boot / x64 / 2008 yok

Checkpoint / VMware Snapshot gibidir.

START -&gt; mmc.exe hypver-v eklenip remote olarak bağlanılabilir.

Hypver-V manager sağ tık new -&gt; harddisk

è VHD eski sanal disk formatı \(2008\) max size 2tb

è Vhdx Windows 2012 max size 64tb

è 2008ler vhdx i göremez

VHD SET -&gt; backup, sanallaştırma

Fixed Size -&gt;  harddiskteki sizin verdiğiniz boyutu kaplar

Performans avantajı ve T-SQL için idealdir.

Dynamic Disk -&gt; İçine veri koydukça büyür

Differencing -&gt; Parça disk

-          Kurulum hatalarında aşağıda ki kodlar sanal makinanın kurulu olduğu klasörde ki ilgili dosyanın en alt satırına yazılmalıdır.

-          Hypervisor.cpuid.v0 = “FALSE”

-          Mce.enable = “TRUE”

-          Vhu.enable =”TRUE” -&gt; Kontrol et

