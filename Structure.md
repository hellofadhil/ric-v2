Struktur & Alur Kerja Proyek

Dokumen ini menjelaskan struktur folder utama, peran tiap modul, dan alur kerja pengembangan.

Struktur Folder Utama
1. Core: library bersama untuk domain model, konfigurasi EF Core, dan kontrak API.
2. OnePro.API: backend ASP.NET Core Web API.
3. OnePro.Front: frontend ASP.NET Core MVC (Razor Views).
5. docs: arsip/backup dan catatan lama.
6. PertaminaV2.sln: solution utama.
7. Readme.md, Run.md: panduan singkat setup dan perintah run.

Core (Shared Library)
1. Contracts: DTO Request/Response yang dipakai lintas proyek (API + Front).
2. Models/Entities: model database (EF Core).
3. Models/Enums: enum status/role.
4. Models/OneProDbContext.cs: konfigurasi EF Core, mapping, conversion, seed data.
5. Migrations: migration EF Core.
6. Extensions, Helpers, Services, Settings: utilitas dan konfigurasi shared.

OnePro.API (Backend)
1. Controllers/V1: endpoint API utama (RIC, Group, RollOut, Auth).
2. Interfaces: kontrak repository (akses data).
3. Repositories: implementasi query, business logic, dan mapping response.
4. DependencyInjection/ServicesExtension.cs: registrasi DI repository.
5. Auth: atribut dan helper autentikasi/otorisasi.
6. appsettings.json: konfigurasi server, connection string, JWT, dsb.

OnePro.Front (Frontend MVC)
1. Controllers: orchestration UI, routing, dan binding form.
2. Services: HTTP client (RestSharp) yang memanggil API.
3. ViewModels: model khusus UI dan response yang dipakai di Razor.
4. Views: Razor pages untuk UI.
5. Helpers, Middleware, Mappers: utilitas UI, auth, dan mapping data.
6. wwwroot: static files dan uploads.
7. appsettings.json: konfigurasi frontend, termasuk ApiUrl.

Alur Kerja Aplikasi (High Level)
1. User berinteraksi di OnePro.Front (Razor Views).
2. Controller Front memanggil Service (HTTP client).
3. Service memanggil endpoint OnePro.API.
4. Controller API memanggil Repository.
5. Repository akses DbContext EF Core atau stored procedure.
6. Response dikembalikan ke Front untuk ditampilkan.

Alur Kerja Pengembangan Fitur Baru
1. Tambah atau ubah Entity di Core/Models/Entities.
2. Update DbContext di Core/Models/OneProDbContext.cs.
3. Buat migration di Core/Migrations.
4. Tambah Contracts (Request/Response) di Core/Contracts sesuai fitur.
5. Buat Interface repository di OnePro.API/Interfaces.
6. Implement repository di OnePro.API/Repositories.
7. Tambah endpoint di OnePro.API/Controllers.
8. Tambah Service di OnePro.Front/Services untuk call API.
9. Buat ViewModel UI di OnePro.Front/ViewModels bila perlu.
10. Buat/ubah View di OnePro.Front/Views dan Controller Front.

Catatan Konvensi
1. Core/Contracts adalah sumber kebenaran kontrak API.
2. OnePro.Front/ViewModels hanya untuk kebutuhan UI.
3. Status dan role mengacu ke Core.Models.Enums.
