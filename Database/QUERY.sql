-- Tabel Keamanan
CREATE TABLE Keamanan (
    IdKeamanan INT PRIMARY KEY,
    NoRekening NVARCHAR(50) UNIQUE,
    LastAccesed NVARCHAR(50),
    AccessHistory NVARCHAR(255)
);

-- Tabel Pelanggan
CREATE TABLE Pelanggan (
    NoRekening NVARCHAR(50) PRIMARY KEY,
    NamaPelanggan NVARCHAR(100),
    AlamatPelanggan NVARCHAR(255),
    NoTelp NVARCHAR(20),
    EmailPelanggan NVARCHAR(100)
);

-- Tabel Tabungan
CREATE TABLE Tabungan (
    IdTabungan INT PRIMARY KEY,
    NoRekening NVARCHAR(50) UNIQUE,
    JenisTabungan NVARCHAR(50),
    SaldoTabungan DECIMAL(18, 2),
    TanggalBuka NVARCHAR(50),
    FOREIGN KEY (NoRekening) REFERENCES Pelanggan(NoRekening)
);

-- Tabel Transaksi
CREATE TABLE Transaksi (
    IdTransaksi INT PRIMARY KEY,
    NoRekening NVARCHAR(50),
    JenisTransaksi NVARCHAR(50),
    TanggalTransaksi NVARCHAR(50),
    DeskripsiTransaksi NVARCHAR(255),
    FOREIGN KEY (NoRekening) REFERENCES Pelanggan(NoRekening)
);
