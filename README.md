# WebApplication2 — ASP.NET MVC 5 (.NET Framework 4.8)

Reproducción paso a paso del video **"Desarrollo de una Aplicación Web ASP.NET MVC (.NET Framework)"**
(https://www.youtube.com/watch?v=fph7UvCsaEk).

Resultado: una página que lista alumnos con su código, nombre, pensión, fecha de nacimiento y estado activo.

---

## Requisitos del video (y su estado en este equipo)

| Elemento del video | En este equipo |
|---|---|
| Visual Studio 2022 | ✅ Instalado (Community 17.14.2) |
| Workload *ASP.NET y desarrollo web* | ✅ Instalado (incluye IIS Express y herramientas web) |
| .NET Framework 4.8 | ✅ Instalado |
| NuGet: Microsoft.AspNet.Mvc 5.2.9 | ✅ Restaurado en `WebApplication2\packages` |

> El proyecto se creó a mano (`WebApplication2.sln` + `WebApplication2.csproj`) con la misma estructura que
> genera la plantilla **Proyecto vacío + MVC**, y se compiló con **MSBuild**. Al principio el equipo no tenía
> el workload web, así que se usó una copia portable de IIS Express; ahora que el workload está instalado,
> **F5 funciona directamente desde Visual Studio** con su propio IIS Express.

---

## Pasos seguidos (los mismos del video)

1. **Proyecto nuevo** → *Aplicación web ASP.NET (.NET Framework)* → nombre sugerido `WebApplication2`.
2. Plantilla **Proyecto vacío** + casillas **MVC**, sin HTTPS.
3. **Models** → agregar clase `Alumno`:
   - Propiedades: `Codigo`, `Nombre`, `Pension` (`double`), `FechaNacimiento` (`DateTime`), `Activo` (`bool`).
   - Constructor con parámetros con prefijo `p` y `Activo = true`.
4. **Controllers** → *Controlador en blanco* `AlumnoController`.
5. **App_Start/RouteConfig.cs** → ruta por defecto `controller = "Alumno"`.
6. En el controlador: lista estática con dos alumnos y `return View(listaAlumnos);`.
7. Clic derecho en la acción `Index` → **Agregar vista** → plantilla **Listar**, modelo `Alumno`.
8. En `_Layout.cshtml`: agregar **Bootstrap por CDN**.
9. En la vista: encabezados **Código / Nombre del alumno / Pensión asignada / Fecha de nacimiento / Activo**,
   pensión con `ToString("C2")` y fecha con `ToString("d")`.

---

## Estructura del proyecto

```
WebApplication2.sln
WebApplication2\
  ├─ App_Start\RouteConfig.cs
  ├─ Controllers\AlumnoController.cs
  ├─ Models\Alumno.cs
  ├─ Views\
  │   ├─ Alumno\Index.cshtml
  │   ├─ Shared\_Layout.cshtml
  │   ├─ _ViewStart.cshtml
  │   └─ Web.config
  ├─ Global.asax(.cs)
  ├─ Properties\AssemblyInfo.cs
  └─ Web.config
packages\  (paquetes NuGet restaurados)
```

## Cómo compilar y ejecutar

Compilar:

```powershell
& "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" `
  "WebApplication2\WebApplication2.csproj" /p:Configuration=Debug
```

Ejecutar: simplemente presionar **F5** en Visual Studio (o `Ctrl+F5` sin depuración).

Visual Studio lanza IIS Express con el proyecto y abre el navegador en la URL indicada en
**Proyecto → Propiedades → Web → Dirección URL del proyecto** (puerto asignado automáticamente).
En esta sesión quedó en <http://localhost:53171/>.

Si se quiere empezar con depuración desde la línea de comandos:

```powershell
& "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe" `
  "WebApplication2.sln" /Run
```

---

## Notas

- Los enlaces **Create / Edit / Details / Delete** que genera el asistente de vistas apuntan a acciones que el video
  no implementa; se dejaron tal cual aparecen en el video.
- El formato de moneda (`C$`) y de fecha (`30/6/2002`) corresponde a la cultura del sistema (`es-NI`).
