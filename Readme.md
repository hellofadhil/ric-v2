Flow Proyek PertaminaV2

Tujuan
Dokumen ini menjelaskan struktur folder utama dan alur kerja dasar proyek agar mudah dipahami oleh developer baru.

Struktur Utama
1. `Core/` - library bersama untuk model domain, contract API, dan konfigurasi data.
2. `OnePro.API/` - backend ASP.NET Core Web API.
3. `OnePro.Front/` - frontend ASP.NET Core MVC (Razor).
4. `docs/` - arsip dan catatan pendukung.
5. `Run.md` - panduan perintah menjalankan aplikasi.

Detail `Core/`
1. `Core/Contracts/` - DTO Request/Response yang dipakai lintas proyek.
2. `Core/Models/` - model domain dan komponen data (detail di bawah).
3. `Core/Migrations/` - migration EF Core.
4. `Core/Extensions/` - extension methods bersama.
5. `Core/Helpers/` - helper umum.
6. `Core/Services/` - service bersama (jika ada).
7. `Core/Settings/` - konfigurasi terpusat.

Detail `Core/Models/`
1. `Core/Models/Entities/` - entity database.
2. `Core/Models/Enums/` - enum status/role/dll.
3. `Core/Models/Interfaces/` - interface untuk model.
4. `Core/Models/Abstracts/` - base class/abstract model.

Detail `OnePro.API/`
1. `OnePro.API/Controllers/` - endpoint API.
2. `OnePro.API/Controllers/V1/` - versi API v1.
3. `OnePro.API/Interfaces/` - kontrak repository.
4. `OnePro.API/Repositories/` - implementasi akses data dan logic.
5. `OnePro.API/DependencyInjection/` - registrasi DI.
6. `OnePro.API/Auth/` - autentikasi/otorisasi.
7. `OnePro.API/bin/`, `OnePro.API/obj/` - hasil build.

Detail `OnePro.Front/`
1. `OnePro.Front/Controllers/` - controller MVC untuk UI.
2. `OnePro.Front/Services/` - pemanggilan API dari frontend.
3. `OnePro.Front/ViewModels/` - model khusus UI.
4. `OnePro.Front/Views/` - Razor Views.
5. `OnePro.Front/Helpers/` - helper UI.
6. `OnePro.Front/Mappers/` - mapping data.
7. `OnePro.Front/Middleware/` - middleware frontend.
8. `OnePro.Front/Properties/` - konfigurasi project.
9. `OnePro.Front/wwwroot/` - static files dan uploads.
10. `OnePro.Front/bin/`, `OnePro.Front/obj/` - hasil build.

Detail `docs/`
1. `docs/_archive/` - arsip/backup dokumen lama.

Alur Data Aplikasi (High Level)
1. User berinteraksi di UI (`OnePro.Front/Views`).
2. Controller frontend memproses input dan memanggil Service.
3. Service frontend memanggil endpoint di `OnePro.API`.
4. Controller API meneruskan ke Repository.
5. Repository akses data melalui EF Core (DbContext di `Core`).
6. Response kembali ke frontend untuk ditampilkan.

Alur Menambah Fitur
1. Tambah atau ubah entity di `Core/Models/Entities/`.
2. Update DbContext dan mapping di `Core/`.
3. Buat migration di `Core/Migrations/`.
4. Tambah DTO di `Core/Contracts/`.
5. Tambah interface repository di `OnePro.API/Interfaces/`.
6. Implementasi repository di `OnePro.API/Repositories/`.
7. Tambah endpoint di `OnePro.API/Controllers/`.
8. Tambah service pemanggil API di `OnePro.Front/Services/`.
9. Tambah ViewModel, Controller, dan View di `OnePro.Front/`.

Flow Auth:
1. Login dari Frontend
2. Token JWT disimpan di session
3. Request ke API pakai Authorization Header
4. Role divalidasi via middleware

Environment:
- .NET SDK: 8.x
- Database: SQL Server LocalDB / SQL Server
- Environment file:
- appsettings.Development.json

Arsitektur:
- Pattern: Layered Architecture + Repository Pattern
- API communication: REST JSON
- Auth: JWT Bearer Token
- ORM: Entity Framework Core
