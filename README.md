# Sistema de Expediente Personal y Académico

A Windows desktop application for managing the **personal records and academic records of students**
(and teachers) at a higher-education institution. Practicum project by Carlos Jesús Moreno.

- **Language / framework:** Visual Basic .NET, Windows Forms, .NET Framework 4.7.2
- **Database:** Microsoft Access (`.accdb`) through the ACE OLEDB provider
- **UI language:** Spanish

---

## How it works

### Startup and login
1. The app starts on the `SIGPAE` form (set in `My Project\Application.Designer.vb`).
2. From the main system menu (`SISTEMA`) the user chooses an area and logs in:
   - `ACCESO ADMINISTRADOR` – personnel/administration area
   - `ACCESO ACADEMICO` – academic area
3. The login form opens an `OleDbConnection` to the Access database and runs a
   `SELECT COUNT(*) FROM [ACCESO ADMINISTRADOR|ACCESO ACADEMICO] WHERE [NOMBRE DE USUARIO] = ...`
   query. If a row is found, the next menu is shown; otherwise an error message appears.

### Menus after login
- **Personnel section** (`Form41 PERSONAL`): student data entry (`Form1 INGRESO ALUMNO`),
  data lookup (`Form2 CONSULTA DE DATOS`), personal-file documents, teacher entry and
  lookup, and the list of *Técnico Superior* students.
- **Academic section** (`Form44 ACADEMICO`): grades per program (*Técnico Superior*),
  student averages (`Form40`), courses by term (*cuatrimestres*), and grades per subject/career.

### Forms
The project has roughly 1,000 forms. Most of them are one screen per program or subject
(for example `ADMINISTRACIÓN DE SERVIDORES DE RED`, `ALGORITMOS BÁSICOS`, `ASIGNATURA 1 …`,
`Form30 NOTAS …`, `Form9–Form25 LISTA DE DOCUMENTOS …`). Each form is three files:
`.vb` (code), `.Designer.vb` (layout) and `.resx` (resources). `MDIParent1–4` are parent windows;
some embed an Adobe PDF viewer control (`AcroPDF`).

### Database
Two Access files sit in the project root and are copied to `bin\Debug` on every build:

| File | Used by |
|---|---|
| `BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO PRACTICA PROFESIONAL CARLOS JESUS MORENO.accdb` | Almost all forms (44 connection strings). Tables include student and teacher data (`INGRESO DE DATOS DE LOS ESTUDIANTES`, `CONSULTA DE DATOS ...`), per-subject grade tables (`NOTA DEL ESTUDIANTE ...`), teacher/subject lists, averages, and the login tables `ACCESO ACADEMICO` / `ACCESO ADMINISTRADOR`. |
| `BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO.accdb` | `Module2.vb` and `App.config` only. Looks like an earlier, smaller version of the schema. |

Connection strings look like this and resolve the database next to the running `.exe`:

```vb
"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\<file>.accdb"
```

---

## Requirements

- Windows 10/11
- Visual Studio (2019 or later) with the **.NET desktop development** workload
- .NET Framework 4.7.2 targeting pack
- **64-bit Microsoft Access Database Engine** (ACE OLEDB) – installed with 64-bit Microsoft Office,
  or as the free *Access Database Engine Redistributable*. The app runs as 64-bit
  (`Prefer32Bit=false`), so a 32-bit-only engine will produce
  *"The 'Microsoft.ACE.OLEDB.12.0' provider is not registered on the local machine"*.

## Running it

1. Open `PROYECTO PRACTICA EXPEDIENTE PERSONAL Y ACADEMICO CARLOS MORENO - copia.sln`.
2. Wait for the status bar to say **Ready**, then **Build → Rebuild Solution**.
3. Press **F5**.

To run it without Visual Studio, copy the whole `bin\Debug` folder to the other PC
(including both `.accdb` files) and run `WindowsApp1.exe`.

**Moving the project to another computer:** copy the entire folder. If you zip it, extract with
Windows Explorer's *Extract All*, and right-click the zip → *Properties* → **Unblock** first if it was
downloaded, or MSBuild fails with error `MSB3821` (mark of the web).

---

## What was changed to make the copied project build and run (2026-09-29)

The project was copied from another machine and did not build. Fixes applied:

1. **Garbled file names (1,695 files).** The copy turned accented characters into other symbols
   (`Ó`→`α`, `Í`→`╓`, `Á`→`╡`, `Ú`→`Θ`), so the `.vbproj` could not find its files
   (error `MSB3041`). Files were renamed back. Log of every rename: `%TEMP%\rename_log.txt`
   (may be gone if temp files were cleaned).
2. **Mark of the web.** Removed the internet-zone flag from all project files (`Unblock-File`),
   which was blocking the build (`MSB3821`).
3. **Missing image.** `Resources\7-16-21-Recursos-de-enseñanza-…-gratuitas.jpg` was never copied.
   A **placeholder** (a copy of `RECURSOS NATURALES Y MEDIO AMBIENTE.jpg`) was created under
   the name the resx expects (the resx stores `ñ`/`á` as decomposed characters). Two forms use it:
   `ASIGNATURAS III CUATRIMESTRE EV` and `ENVIO DE NOTAS DE ASIGNATURAS EV 3`.
4. **Solution file.** The `.sln` pointed to `WindowsApp1\PROYECTO….vbproj`, a subfolder that does not exist,
   so Visual Studio could not load the project (Start button disabled). Path corrected.
5. **Hard-coded database paths (45 places).** The code pointed to `C:\Users\FS\Documents\…`
   (the original author's machine). They now use `My.Application.Info.DirectoryPath`.
   44 point to the *PRACTICA PROFESIONAL* database, and 1 (`Module2.vb`) to the other one.
   25 `.vb` files were edited. Three of them (`ACCESO ACADEMICO`, `ACCESO ADMINISTRADOR`,
   `ADMINISTRADOR`) were not UTF-8 and had accented characters damaged during the edit; those words
   were restored (`CONTRASEÑA`, `sesión`, `código`, …) and the build passes.
6. **Second database in the project.** The *PRACTICA PROFESIONAL* `.accdb` was added to the `.vbproj`
   with *Copy Always* so it lands in `bin\Debug`.
7. **64-bit execution.** `<Prefer32Bit>false</Prefer32Bit>` added. The exe was being built
   "32-bit preferred", which could not use the 64-bit ACE provider installed with Office.
   Making the target `x64` was tried and rejected: the `AcroPDFLib` COM reference is 32-bit only and fails to resolve.

Result: the solution builds with 0 errors and the login works.

---

## Known issues / to do

- **The login does not check the password.** The query only filters on `NOMBRE DE USUARIO`;
  the password is added as a parameter but is not part of the SQL, so any password works for a valid
  username. Passwords are also stored/compared as plain text. This should be fixed before real use.
- **Logo missing.** `Form2 CONSULTA DE DATOS`, `Form40` and `FORMULARIO CONSULTA PROFESORES` load
  `C:\Users\FS\Downloads\images cc.jpg`. They check that it exists, so nothing crashes, but reports have no logo.
- **Placeholder image** (item 3 above) should be replaced with the original.
- **`AcroPDF` control** is 32-bit only; forms that embed it (`MDIParent1`, `MDIParent2`, `Form2`,
  `FORMULARIO CONSULTA PROFESORES`) have not been tested in the 64-bit build.
- **Repeated code.** Each form builds its own connection string and repeats the same data-access code;
  a single shared connection helper would make changes like the path fix a one-line edit
  (`conexion\Open.vb` and `Close.vb` look like an unfinished attempt at this).
- The student-data `.accdb` files should **not** be committed to a public repository.
