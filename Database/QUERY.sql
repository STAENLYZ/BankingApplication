CREATE TABLE Pelanggan(
NamaPelanggan varchar(100) not null,
NoRekening varchar(16) primary key not null,
Alamat varchar(150) ,
NoTelp varchar(14),
Email varchar(255)
)

CREATE TABLE Transaksi(
NoRekening varchar(16) foreign key references Pelanggan(NoRekening),
JenisTransaksi varchar(50) not null,
TanggalTransaksi datetime,
JumlahTransaksi money
)