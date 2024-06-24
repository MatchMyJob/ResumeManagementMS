using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resume",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinimumSalary = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "StudyType",
                columns: table => new
                {
                    StudyTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyType", x => x.StudyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Experience",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jobDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experience", x => x.ExperienceId);
                    table.ForeignKey(
                        name: "FK_Experience_Resume_UserId",
                        column: x => x.UserId,
                        principalTable: "Resume",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResumeSkill",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumeSkill", x => new { x.UserId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ResumeSkill_Resume_UserId",
                        column: x => x.UserId,
                        principalTable: "Resume",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResumeSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Study",
                columns: table => new
                {
                    StudyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudyTypeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Study", x => x.StudyId);
                    table.ForeignKey(
                        name: "FK_Study_Resume_UserId",
                        column: x => x.UserId,
                        principalTable: "Resume",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Study_StudyType_StudyTypeId",
                        column: x => x.StudyTypeId,
                        principalTable: "StudyType",
                        principalColumn: "StudyTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Resume",
                columns: new[] { "UserId", "Description", "Image", "MinimumSalary" },
                values: new object[,]
                {
                    { new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2"), "¡Hola! Soy Marcos Pérez, un ingeniero de software con una pasión por la tecnología y la innovación. Con más de 8 años de experiencia en desarrollo de software, he trabajado en una variedad de proyectos, desde aplicaciones móviles hasta sistemas de gestión empresarial. Mi enfoque se centra en la calidad del código y la eficiencia del producto, asegurándome de que cada aplicación cumpla con los más altos estándares de rendimiento y seguridad. Estoy comprometido con el aprendizaje continuo y la mejora de mis habilidades y estoy emocionado de colaborar en proyectos que desafíen mi capacidad de innovación. ¡Contáctame y llevemos tu proyecto al siguiente nivel!", "https://example.com/image_marcos.jpg", 85000 },
                    { new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f"), "¡Hola! Soy Gloria Ramos, una profesional del marketing digital con experiencia en estrategias de contenido, redes sociales y publicidad online. A lo largo de mi carrera, he tenido el privilegio de trabajar con una variedad de clientes y marcas para ayudarles a alcanzar sus objetivos de marketing. Mi enfoque se centra en entender las necesidades y preferencias de la audiencia para crear campañas efectivas que generen resultados tangibles. Estoy comprometida con la excelencia en cada proyecto y estoy emocionada de poder contribuir con mi experiencia a tu equipo. ¡Juntos podemos crear estrategias que impulsen tu negocio hacia el éxito!", "https://example.com/image_gloria.jpg", 65000 },
                    { new Guid("0b450794-1b65-4d42-8df7-05b57b970454"), "¡Hola! Soy José, un contador público con una pasión por los números y el análisis financiero. Con más de 7 años de experiencia en contabilidad y finanzas, he trabajado en una variedad de roles, desde auditoría hasta consultoría fiscal. Mi enfoque se centra en la precisión y la integridad de la información financiera, asegurando el cumplimiento de las normativas y la optimización de los recursos financieros. Estoy comprometido con la excelencia en la gestión financiera y estoy emocionado de colaborar en proyectos que impulsen el crecimiento económico. ¡Contáctame y juntos aseguremos el éxito financiero de tu empresa!", "https://example.com/image_jose.jpg", 95000 },
                    { new Guid("0e5a9aab-eb68-4ca9-8b80-ea7bef076946"), "¡Hola! Soy Laura, una investigadora científica apasionada por la exploración del universo y la comprensión de sus misterios. Con más de 10 años de experiencia en astronomía, he contribuido a una variedad de proyectos de investigación, desde el estudio de exoplanetas hasta la exploración del cosmos distante. Mi enfoque se centra en la astrofísica y la cosmología, buscando respuestas a preguntas fundamentales sobre el origen y la evolución del universo. Estoy comprometida con la divulgación científica y estoy emocionada de colaborar en proyectos que acerquen la ciencia a la sociedad. ¡Contáctame y exploremos juntos los secretos del universo!", "https://example.com/image_laura.jpg", 100000 },
                    { new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f"), "¡Hola! Soy Rosa González, una profesional de recursos humanos con una pasión por reclutar y retener el mejor talento. Con más de 7 años de experiencia en reclutamiento, he trabajado en una variedad de sectores, desde tecnología hasta servicios financieros. Mi enfoque se centra en entender las necesidades de la empresa y encontrar candidatos que no solo tengan las habilidades necesarias, sino que también se ajusten a la cultura organizacional. Estoy comprometida con la equidad y la diversidad en el lugar de trabajo y estoy emocionada de colaborar en proyectos que promuevan un ambiente laboral inclusivo y acogedor. ¡Contáctame y llevemos tu equipo al siguiente nivel!", "https://example.com/image_rosa.jpg", 95000 },
                    { new Guid("153ff2f4-ccb7-43b1-b163-8f995adb1d13"), "¡Hola! Soy Diego, un ingeniero civil con una pasión por el diseño y la construcción de infraestructuras innovadoras. Con más de 7 años de experiencia en ingeniería civil, he trabajado en una variedad de proyectos, desde edificios residenciales hasta carreteras y puentes. Mi enfoque se centra en la sostenibilidad y la eficiencia, buscando siempre soluciones que mejoren la calidad de vida de las personas y respeten el medio ambiente. Estoy comprometido con la excelencia en la ingeniería y estoy emocionado de colaborar en proyectos que transformen el mundo que nos rodea. ¡Contáctame y construyamos un futuro mejor juntos!", "https://example.com/image_diego.jpg", 100000 },
                    { new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea"), "¡Hola! Soy Ignacio, un desarrollador de software apasionado por la creación de soluciones tecnológicas innovadoras. Con más de 5 años de experiencia en desarrollo de software, he trabajado en una variedad de proyectos, desde aplicaciones móviles hasta sistemas de gestión empresarial. Mi enfoque se centra en la calidad del código y la usabilidad del producto, asegurándome de que cada aplicación sea intuitiva y fácil de usar. Estoy comprometido con el aprendizaje continuo y la mejora de mis habilidades y estoy emocionado de colaborar en proyectos que desafíen mi capacidad de innovación. ¡Contáctame y trabajemos juntos para crear software que marque la diferencia!", "https://example.com/image_ignacio.jpg", 100000 },
                    { new Guid("19d1cc4c-18e4-42fc-9cbd-56253b20165e"), "¡Hola! Soy Claudia Ramírez, una enfermera comprometida con la prestación de atención médica de alta calidad y compasiva. Con más de 5 años de experiencia en enfermería, he trabajado en una variedad de entornos, desde hospitales hasta centros de atención a largo plazo. Mi enfoque se centra en el bienestar holístico de mis pacientes, brindando atención centrada en el paciente que aborde tanto sus necesidades físicas como emocionales. Estoy comprometida con la excelencia en la atención médica y estoy emocionada de colaborar en proyectos que me permitan hacer una diferencia positiva en la vida de las personas. ¡Contáctame y juntos promoveremos la salud y el bienestar!", "https://example.com/image_claudia.jpg", 100000 },
                    { new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae"), "¡Hola! Soy Carmen Flores, una enfermera dedicada y compasiva con una pasión por brindar atención de calidad a mis pacientes. Con más de 10 años de experiencia en el campo de la salud, he trabajado en una variedad de entornos, desde hospitales hasta centros de atención primaria. Mi enfoque se centra en el cuidado integral del paciente, brindando apoyo emocional y físico en cada etapa del proceso de atención médica. Estoy comprometida con la excelencia en el cuidado de la salud y estoy emocionada de colaborar en proyectos que mejoren la calidad de vida de las personas. ¡Contáctame y trabajemos juntos para hacer una diferencia en la vida de los demás!", "https://example.com/image_carmen.jpg", 85000 },
                    { new Guid("1cdb46ef-e0a5-427c-8409-9a58cde54ce9"), "¡Hola! Soy Luis, un desarrollador web con una pasión por la creación de sitios web dinámicos y funcionales. Con más de 4 años de experiencia en desarrollo web, tengo habilidades sólidas en HTML, CSS, JavaScript y frameworks como React y Angular. Mi enfoque se centra en la usabilidad y la experiencia del usuario, buscando siempre crear interfaces intuitivas y atractivas. Estoy comprometido con la mejora continua y estoy emocionado de colaborar en proyectos que desafíen mis habilidades técnicas. ¡Contáctame y construyamos la próxima gran experiencia web juntos!", "https://example.com/image_luis.jpg", 80000 },
                    { new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423"), "¡Hola! Soy Fernando, un chef apasionado por la gastronomía y la creación de experiencias culinarias memorables. Con más de 10 años de experiencia en la industria de la restauración, he trabajado en una variedad de cocinas, desde la cocina tradicional hasta la alta cocina. Mi enfoque se centra en la calidad de los ingredientes y la innovación en la presentación, buscando siempre sorprender y deleitar a los comensales. Estoy comprometido con la excelencia en la cocina y estoy emocionado de colaborar en proyectos que celebren la diversidad gastronómica. ¡Contáctame y juntos creemos platos que despierten tus sentidos!", "https://example.com/image_fernando.jpg", 110000 },
                    { new Guid("2301041e-8c28-4711-b70d-9daed300ae21"), "¡Hola! Soy Víctor García, un contador público certificado con una amplia experiencia en contabilidad financiera y gestión fiscal. Con más de 10 años de experiencia en contabilidad, he trabajado en una variedad de industrias, desde servicios profesionales hasta manufactura. Mi enfoque se centra en la precisión y la integridad de los datos financieros, asegurándome de que cada informe sea exacto y cumpla con las normativas vigentes. Estoy comprometido con la excelencia en la contabilidad y estoy emocionado de colaborar en proyectos que me permitan aplicar mi experiencia y conocimientos. ¡Contáctame y trabajemos juntos para optimizar tus operaciones financieras!", "https://example.com/image_victor.jpg", 120000 },
                    { new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e"), "¡Hola! Soy Miriam López, una periodista apasionada por contar historias que inspiren y conecten con la audiencia. Con más de 5 años de experiencia en medios de comunicación, he cubierto una variedad de temas, desde política hasta cultura. Mi enfoque se centra en la investigación y la narración, buscando siempre la verdad y la objetividad en mis reportajes. Estoy comprometida con el periodismo ético y estoy emocionada de colaborar en proyectos que informen y empoderen a la sociedad. ¡Contáctame y juntos contemos la próxima gran historia!", "https://example.com/image_miriam.jpg", 75000 },
                    { new Guid("2d624f65-a74a-4011-a187-862f58df7885"), "¡Hola! Soy Patricia Flores, una psicóloga clínica con una pasión por ayudar a las personas a alcanzar su máximo potencial. Con más de 10 años de experiencia en psicoterapia, he trabajado con una variedad de clientes, desde niños hasta adultos mayores. Mi enfoque se centra en el bienestar emocional y el crecimiento personal, ofreciendo un enfoque integrador que combine diferentes técnicas terapéuticas. Estoy comprometida con la salud mental y el bienestar y estoy emocionada de colaborar en proyectos que promuevan el desarrollo humano. ¡Contáctame y juntos trabajemos para mejorar tu calidad de vida!", "https://example.com/image_patricia.jpg", 95000 },
                    { new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439"), "¡Hola! Soy Pedro Gomez, un ingeniero de software con experiencia en el desarrollo de aplicaciones empresariales y sistemas informáticos. Con más de 7 años de experiencia en el campo, he trabajado en una variedad de proyectos que abarcan desde aplicaciones de gestión hasta sistemas de análisis de datos. Mi enfoque se centra en la calidad del código, la eficiencia y la escalabilidad de las soluciones que desarrollo. Estoy emocionado de contribuir con mi experiencia a tu equipo y ayudarte a alcanzar tus objetivos tecnológicos. ¡Juntos podemos construir soluciones innovadoras que impulsen tu negocio hacia el éxito!", "https://example.com/image_pedro.jpg", 70000 },
                    { new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e"), "¡Hola! Soy María, una diseñadora de moda apasionada por la creatividad y la innovación en la industria textil. Con más de 5 años de experiencia en diseño de moda, he trabajado en una variedad de proyectos, desde colecciones de prêt-à-porter hasta diseños personalizados. Mi enfoque se centra en la combinación de estilos tradicionales y contemporáneos, creando prendas que sean tanto elegantes como funcionales. Estoy comprometida con la sostenibilidad en la moda y estoy emocionada de colaborar en proyectos que promuevan prácticas éticas en la industria. ¡Contáctame y juntos creemos diseños que marquen tendencia!", "https://example.com/image_maria.jpg", 80000 },
                    { new Guid("31550335-200e-442a-9cca-f1d0f62c0819"), "¡Hola! Soy Andrea Ramírez, una diseñadora de moda con una pasión por la creatividad y la expresión artística. Con más de 8 años de experiencia en la industria de la moda, he trabajado en una variedad de roles, desde diseño de prendas hasta dirección de arte. Mi enfoque se centra en la innovación y la sostenibilidad, creando colecciones que sean tanto visualmente impactantes como éticamente responsables. Estoy comprometida con la inclusión y la diversidad en la moda y estoy emocionada de colaborar en proyectos que celebren la individualidad y la autenticidad. ¡Contáctame y juntos crearemos moda que inspire y empodere!", "https://example.com/image_andrea.jpg", 110000 },
                    { new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f"), "¡Hola! Soy Alejandro, un ingeniero civil con experiencia en el diseño y construcción de infraestructuras civiles. Con más de 8 años de experiencia en el campo, he trabajado en una variedad de proyectos que van desde edificios residenciales hasta carreteras y puentes. Mi enfoque se centra en la calidad del diseño, la seguridad y la eficiencia de las estructuras que construyo. Estoy emocionado de contribuir con mi experiencia a tu equipo y ayudarte a llevar a cabo proyectos que mejoren la calidad de vida de las personas. ¡Juntos podemos construir un futuro mejor!", "https://example.com/image_alejandro.jpg", 95000 },
                    { new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36"), "¡Hola! Soy Carmen Lopez, una diseñadora de moda con una pasión por la creación de prendas únicas y elegantes. Con un ojo para las tendencias y una habilidad para combinar colores y telas de manera creativa, he creado colecciones que han cautivado a clientes de todo el mundo. Mi enfoque se centra en la calidad, la originalidad y la atención al detalle, y estoy comprometida a ofrecer productos que no solo sean hermosos, sino también cómodos y funcionales. Estoy emocionada de colaborar en proyectos que me permitan expresar mi creatividad y contribuir al mundo de la moda. ¡Contáctame y hagamos magia juntos!", "https://example.com/image_carmen.jpg", 75000 },
                    { new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2"), "¡Hola! Soy Lorena Díaz, una consultora de marketing digital con una pasión por ayudar a las empresas a alcanzar su máximo potencial en línea. Con más de 6 años de experiencia en marketing digital, he trabajado con una variedad de clientes, desde startups hasta empresas consolidadas. Mi enfoque se centra en la estrategia y la ejecución, desarrollando campañas que generen resultados tangibles y aumenten la visibilidad de la marca. Estoy comprometida con la innovación y la creatividad en el marketing y estoy emocionada de colaborar en proyectos que desafíen mis habilidades y conocimientos. ¡Contáctame y llevemos tu estrategia de marketing al siguiente nivel!", "https://example.com/image_lorena.jpg", 130000 },
                    { new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3"), "¡Hola! Soy Víctor Morales, un periodista apasionado por contar historias y comunicar ideas de manera efectiva. Con más de 10 años de experiencia en la industria, he trabajado en una variedad de medios, desde periódicos locales hasta revistas nacionales. Mi enfoque se centra en la investigación exhaustiva y la redacción precisa para informar, educar y entretener a los lectores. Estoy emocionado de colaborar en proyectos que me permitan contar historias impactantes y generar un impacto positivo en la sociedad. ¡Contáctame y trabajemos juntos para dar vida a tus ideas y mensajes!", "https://example.com/image_victor.jpg", 75000 },
                    { new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9"), "¡Hola! Soy Isabel, una escritora apasionada por las palabras y las historias que cuentan. Con más de 8 años de experiencia en redacción y edición, he trabajado en una variedad de proyectos editoriales, desde novelas hasta artículos periodísticos. Mi enfoque se centra en la claridad y la expresión creativa, buscando siempre transmitir mensajes significativos y emocionantes. Estoy comprometida con la excelencia en la escritura y estoy emocionada de colaborar en proyectos que inspiren y entretengan a los lectores. ¡Contáctame y juntos creemos historias que perduren para siempre!", "https://example.com/image_isabel.jpg", 85000 },
                    { new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b"), "¡Hola! Soy José Manuel, un contador público con experiencia en auditoría y análisis financiero. Con más de 10 años de experiencia en el campo, he trabajado en una variedad de industrias, desde la banca hasta la consultoría. Mi enfoque se centra en proporcionar informes financieros precisos y estratégicos que ayuden a las empresas a tomar decisiones informadas y alcanzar sus objetivos financieros. Estoy comprometido con la excelencia en cada proyecto y estoy emocionado de poder contribuir con mi experiencia a tu equipo. ¡Contáctame y trabajemos juntos para impulsar el éxito financiero de tu empresa!", "https://example.com/image_josemanuel.jpg", 90000 },
                    { new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4"), "¡Hola! Soy Francisco, un ingeniero de software con experiencia en el desarrollo de aplicaciones web y móviles. Con más de 6 años de experiencia en el campo, he trabajado en una variedad de proyectos, desde startups hasta grandes empresas. Mi enfoque se centra en la calidad del código, la escalabilidad y la seguridad de las soluciones que desarrollo. Estoy emocionado de contribuir con mi experiencia a tu equipo y ayudarte a alcanzar tus objetivos tecnológicos. ¡Juntos podemos construir soluciones innovadoras que impulsen tu negocio hacia el éxito!", "https://example.com/image_francisco.jpg", 100000 },
                    { new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9"), "Miguel Sanchez es un ingeniero de software con experiencia en el desarrollo de aplicaciones móviles nativas para iOS y Android. Su profundo conocimiento de Swift, Kotlin y las mejores prácticas de diseño de aplicaciones lo ha llevado a entregar productos de alta calidad que cumplen con las expectativas del cliente. Miguel es un solucionador de problemas habilidoso con una pasión por la innovación tecnológica. Con una mentalidad orientada al detalle y una capacidad para gestionar proyectos complejos, Miguel está preparado para enfrentar cualquier desafío de desarrollo móvil con éxito.", "https://example.com/image_miguel.jpg", 65000 },
                    { new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f"), "¡Hola! Soy Lucia Ramos, una fotógrafa apasionada por capturar momentos especiales y crear recuerdos duraderos a través de la fotografía. Con más de 5 años de experiencia en la industria, he tenido el privilegio de trabajar en una variedad de eventos, desde bodas y sesiones familiares hasta eventos corporativos y comerciales. Mi enfoque se centra en capturar la esencia y la emoción de cada momento de una manera auténtica y artística. Estoy emocionada de colaborar en proyectos que me permitan expresar mi creatividad y contar historias a través de mis imágenes. ¡Contáctame y creemos recuerdos juntos!", "https://example.com/image_lucia.jpg", 75000 },
                    { new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6"), "¡Hola! Soy Carmen, una diseñadora gráfica apasionada por la creatividad y la expresión visual. Con más de 6 años de experiencia en diseño gráfico, he trabajado en una variedad de proyectos, desde branding corporativo hasta diseño editorial. Mi enfoque se centra en la estética y la comunicación visual, buscando siempre transmitir mensajes claros y emocionantes. Estoy comprometida con la innovación en el diseño y estoy emocionada de colaborar en proyectos que desafíen mi creatividad. ¡Contáctame y llevemos tus ideas al siguiente nivel visual!", "https://example.com/image_carmen.jpg", 85000 },
                    { new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f"), "¡Hola! Soy David Martin, un apasionado desarrollador de software con una sólida experiencia en el desarrollo de aplicaciones web y móviles. Mi fascinación por la tecnología y mi habilidad para resolver problemas me han llevado a construir aplicaciones robustas y escalables que satisfacen las necesidades de mis clientes. Con habilidades en múltiples lenguajes de programación y frameworks, estoy preparado para enfrentar cualquier desafío de desarrollo que se presente. Siempre estoy buscando oportunidades para aprender y crecer profesionalmente, y estoy emocionado de contribuir con mi experiencia a tu próximo proyecto. ¡Hablemos y veamos cómo puedo ayudarte a alcanzar tus objetivos tecnológicos!", "https://example.com/image_david.jpg", 65000 },
                    { new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5"), "¡Hola! Soy Adriana Pérez, una diseñadora gráfica apasionada por la creación de identidades visuales impactantes y creativas. Con más de 8 años de experiencia en la industria, he trabajado en una variedad de proyectos, desde el diseño de logotipos hasta campañas publicitarias completas. Mi enfoque se centra en entender las necesidades y objetivos de mis clientes para crear diseños únicos y memorables que comuniquen su mensaje de manera efectiva. Estoy emocionada de colaborar en proyectos que me permitan aplicar mi creatividad y experiencia para ayudar a las marcas a destacarse en un mercado competitivo. ¡Contáctame y hagamos magia juntos!", "https://example.com/image_adriana.jpg", 80000 },
                    { new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd"), "¡Hola! Soy Beatriz, una diseñadora de moda apasionada por la creación de prendas únicas y elegantes. Con más de 6 años de experiencia en la industria, he trabajado en el diseño de ropa para diversas ocasiones, desde desfiles de moda hasta eventos exclusivos. Mi enfoque se centra en la combinación de creatividad y funcionalidad para crear colecciones que reflejen las últimas tendencias y satisfagan las necesidades de mis clientes. Estoy emocionada de colaborar en proyectos que me permitan expresar mi pasión por la moda y crear piezas que inspiren confianza y estilo. ¡Contáctame y hagamos realidad tus ideas de moda!", "https://example.com/image_beatriz.jpg", 80000 },
                    { new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f"), "¡Hola! Soy Diego López, un chef apasionado por la gastronomía y la creación de experiencias culinarias memorables. Con más de 10 años de experiencia en la industria, he tenido el privilegio de trabajar en una variedad de restaurantes, desde pequeños bistros hasta establecimientos de alta cocina. Mi enfoque se centra en la calidad de los ingredientes, la creatividad en la presentación y la atención al detalle en cada plato que preparo. Estoy emocionado de colaborar en proyectos que me permitan compartir mi pasión por la cocina y sorprender a los comensales con sabores únicos y deliciosos. ¡Contáctame y organicemos una experiencia gastronómica inolvidable!", "https://example.com/image_diego.jpg", 70000 },
                    { new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb"), "¡Hola! Soy Juliana González, una diseñadora gráfica con una pasión por la creatividad y la innovación. Con más de 6 años de experiencia en diseño gráfico, he trabajado en una variedad de proyectos, desde identidad corporativa hasta diseño editorial. Mi enfoque se centra en la estética y la funcionalidad, creando diseños que sean tanto visualmente impactantes como efectivos en la comunicación. Estoy comprometida con la excelencia en el diseño y estoy emocionada de colaborar en proyectos que desafíen mi creatividad. ¡Contáctame y juntos crearemos diseños que marquen la diferencia!", "https://example.com/image_juliana.jpg", 80000 },
                    { new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1"), "¡Hola! Soy Ana Maria, una diseñadora de interiores apasionada por crear espacios acogedores y funcionales que reflejen la personalidad y el estilo de mis clientes. Con más de 8 años de experiencia en la industria, he trabajado en una variedad de proyectos residenciales y comerciales, desde pequeñas renovaciones hasta remodelaciones completas. Mi enfoque se centra en entender las necesidades y gustos de mis clientes para crear diseños únicos y personalizados que superen sus expectativas. Estoy emocionada de colaborar en proyectos que me permitan expresar mi creatividad y mejorar la calidad de vida de las personas a través del diseño de interiores. ¡Contáctame y hagamos realidad tu visión!", "https://example.com/image_ana.jpg", 70000 },
                    { new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad"), "Marta Rivera es una desarrolladora front-end con experiencia en React, Vue.js y Angular. Con un enfoque en la creación de interfaces de usuario dinámicas y responsivas, Marta ha contribuido al éxito de varios proyectos web. Su habilidad para colaborar efectivamente con diseñadores y desarrolladores la convierte en un miembro valioso de cualquier equipo. Marta está comprometida con la mejora continua y está constantemente explorando nuevas tecnologías y técnicas para mantenerse al día con las últimas tendencias en desarrollo web.", "https://example.com/image_marta.jpg", 55000 },
                    { new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8"), "¡Hola! Soy Juan Carlos, un desarrollador de aplicaciones móviles con experiencia en el diseño y desarrollo de aplicaciones nativas para iOS y Android. Mi pasión por la tecnología y mi habilidad para traducir ideas creativas en productos funcionales me han permitido crear aplicaciones que impactan positivamente en la vida de los usuarios. Con un enfoque en la usabilidad y el rendimiento, me esfuerzo por ofrecer experiencias móviles de alta calidad que superen las expectativas del cliente. Estoy emocionado de trabajar en tu próximo proyecto y contribuir con mi experiencia para hacerlo un éxito. ¡Hablemos y hagamos realidad tu visión!", "https://example.com/image_juan.jpg", 70000 },
                    { new Guid("597719b7-3036-4f95-92f8-5163b3e18931"), "Jose Luis es un desarrollador full-stack con experiencia en diversas tecnologías, incluyendo Java, Python y JavaScript. Con más de 8 años de experiencia en el campo, José ha liderado equipos de desarrollo y ha entregado proyectos exitosos en plazos ajustados. Su pasión por la resolución de problemas y su enfoque en la calidad del código lo distinguen como un profesional altamente competente. José está constantemente buscando oportunidades para crecer y aprender, y está comprometido con la excelencia en todo lo que hace.", "https://example.com/image_jose.jpg", 60000 },
                    { new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2"), "¡Hola! Soy Alberto García, un consultor financiero con una amplia experiencia en el análisis y la gestión de inversiones. Con más de 8 años de experiencia en el sector financiero, he trabajado con una variedad de clientes, desde individuos hasta corporaciones, para ayudarles a alcanzar sus objetivos financieros. Mi enfoque se centra en proporcionar asesoramiento personalizado que maximice el rendimiento de la inversión y minimice los riesgos. Estoy comprometido con la integridad y la transparencia en mi trabajo y estoy emocionado de colaborar en proyectos que me permitan aplicar mi experiencia y conocimientos financieros. ¡Contáctame y trabajemos juntos para optimizar tu cartera de inversiones!", "https://example.com/image_alberto.jpg", 120000 },
                    { new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84"), "Maria Garcia es una profesional apasionada por el desarrollo web, con experiencia en HTML, CSS y JavaScript. Su enfoque meticuloso en el diseño y la usabilidad le ha permitido crear interfaces atractivas y funcionales. María se destaca por su habilidad para trabajar en equipo y su capacidad para adaptarse rápidamente a nuevas tecnologías. Con un historial probado de entrega de proyectos de calidad en plazos ajustados, María es una adición valiosa a cualquier equipo de desarrollo.", "https://example.com/image_maria.jpg", 45000 },
                    { new Guid("60786725-191b-4172-acd8-ef669024173b"), "¡Hola! Soy Jorge, un ingeniero civil con experiencia en el diseño y la construcción de proyectos de infraestructura. Con más de 10 años de experiencia en el campo, he trabajado en una variedad de proyectos, desde carreteras hasta puentes y edificios. Mi enfoque se centra en la calidad, la seguridad y la eficiencia en cada proyecto que emprendo. Estoy comprometido con la excelencia en el diseño y la ejecución de proyectos que mejoren la calidad de vida de las personas. ¡Contáctame y trabajemos juntos para construir un futuro mejor!", "https://example.com/image_jorge.jpg", 110000 },
                    { new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1"), "¡Hola! Soy Sofia Gonzalez, una contadora pública con experiencia en la gestión financiera y contable de empresas. Con más de 7 años de experiencia en el campo, he trabajado en una variedad de industrias, desde la manufactura hasta la tecnología. Mi enfoque se centra en proporcionar información financiera precisa y oportuna que permita a las empresas tomar decisiones informadas y estratégicas. Estoy comprometida con la excelencia en cada proyecto y estoy emocionada de poder contribuir con mi experiencia a tu equipo. ¡Juntos podemos lograr el éxito financiero de tu empresa!", "https://example.com/image_sofia.jpg", 90000 },
                    { new Guid("6d46504c-1a72-4036-98e3-3434676e05bb"), "¡Hola! Soy Juan Antonio, un desarrollador de software con experiencia en el diseño y desarrollo de aplicaciones web y móviles. Con más de 6 años de experiencia en el campo, he trabajado en una variedad de proyectos que van desde startups hasta grandes empresas. Mi enfoque se centra en la calidad del código, la eficiencia y la escalabilidad de las soluciones que desarrollo. Estoy emocionado de contribuir con mi experiencia a tu equipo y ayudarte a alcanzar tus objetivos tecnológicos. ¡Juntos podemos construir soluciones innovadoras que impulsen tu negocio hacia el éxito!", "https://example.com/image_juan.jpg", 80000 },
                    { new Guid("70e6cdc7-85df-452f-84ea-5e985024734c"), "¡Hola! Soy Raúl Pérez, un contador público con experiencia en la gestión financiera y la planificación fiscal. Con más de 8 años de experiencia en el campo, he trabajado con una variedad de clientes, desde pequeñas empresas hasta corporaciones multinacionales. Mi enfoque se centra en proporcionar asesoramiento financiero estratégico que ayude a mis clientes a tomar decisiones informadas y alcanzar sus objetivos financieros. Estoy comprometido con la integridad y la precisión en mi trabajo y estoy emocionado de colaborar en proyectos que me permitan aplicar mis conocimientos y habilidades. ¡Contáctame y trabajemos juntos para optimizar tus finanzas!", "https://example.com/image_raul.jpg", 105000 },
                    { new Guid("7c5891f9-9fac-4dbf-9afd-2c9e01759e20"), "¡Hola! Soy Alejandra, una escritora independiente con una pasión por contar historias cautivadoras. Con más de 4 años de experiencia en escritura creativa, he trabajado en una variedad de proyectos, desde novelas hasta guiones y artículos de blog. Mi enfoque se centra en la emoción y la autenticidad, buscando siempre conectar con los lectores a un nivel profundo. Estoy comprometida con la excelencia en la escritura y estoy emocionada de colaborar en proyectos que inspiren y entretengan a las personas. ¡Contáctame y juntos creemos historias que perduren para siempre!", "https://example.com/image_alejandra.jpg", 85000 },
                    { new Guid("7e246319-564e-4920-bd8c-6029be2a7729"), "¡Hola! Soy Elena Diaz, una profesional del marketing digital con una pasión por la creación de estrategias innovadoras y efectivas. Con más de 5 años de experiencia en el campo, he trabajado en una variedad de proyectos que abarcan desde redes sociales hasta campañas de email marketing. Mi enfoque se centra en comprender las necesidades del cliente y crear soluciones personalizadas que impulsen el compromiso y la conversión. Estoy comprometida con la excelencia en cada proyecto y estoy emocionada de poder contribuir con mi experiencia a tu equipo. ¡Juntos podemos crear estrategias que impulsen tu negocio hacia el éxito!", "https://example.com/image_elena.jpg", 60000 },
                    { new Guid("80120fd9-ade7-4cd0-9dda-7b733e02d7cd"), "¡Hola! Soy Carlos, un desarrollador web con una pasión por la creación de experiencias digitales innovadoras. Con más de 8 años de experiencia en desarrollo web, he trabajado en una variedad de proyectos, desde sitios web corporativos hasta aplicaciones web complejas. Mi enfoque se centra en la usabilidad y el rendimiento, asegurándome de que cada proyecto cumpla con los más altos estándares de calidad. Estoy comprometido con la mejora continua y estoy emocionado de colaborar en proyectos que desafíen mis habilidades técnicas. ¡Contáctame y llevemos tu presencia en línea al siguiente nivel!", "https://example.com/image_carlos.jpg", 90000 },
                    { new Guid("81319e22-745a-45c6-9402-6d1389fd0f44"), "¡Hola! Soy Natalia Ramírez, una diseñadora gráfica apasionada por la creación de soluciones visuales impactantes. Con más de 6 años de experiencia en diseño gráfico, he trabajado en una variedad de proyectos, desde identidades de marca hasta diseño editorial. Mi enfoque se centra en la creatividad y la atención al detalle, asegurándome de que cada diseño transmita el mensaje deseado de manera efectiva. Estoy comprometida con la innovación y la excelencia en mi trabajo y estoy emocionada de colaborar en proyectos que me permitan expresar mi creatividad y mejorar mis habilidades. ¡Contáctame y juntos crearemos diseños que inspiren y cautiven!", "https://example.com/image_natalia.jpg", 90000 },
                    { new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3"), "¡Hola! Soy Valeria González, una consultora de marketing digital apasionada por ayudar a las empresas a alcanzar su máximo potencial en línea. Con más de 5 años de experiencia en marketing digital, he trabajado con clientes de diversas industrias para desarrollar estrategias de marketing efectivas y alcanzar objetivos comerciales. Mi enfoque se centra en la generación de contenido relevante, la optimización de SEO y la gestión de campañas publicitarias en redes sociales. Estoy comprometida con la innovación y el crecimiento en el campo del marketing digital y estoy emocionada de colaborar en proyectos que me desafíen y me permitan seguir aprendiendo. ¡Contáctame y llevemos tu marca al siguiente nivel!", "https://example.com/image_valeria.jpg", 100000 },
                    { new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da"), "¡Hola! Soy Mónica, una consultora de marketing digital con una pasión por conectar marcas con su audiencia en línea. Con más de 7 años de experiencia en marketing digital, he trabajado en una variedad de proyectos, desde campañas de redes sociales hasta estrategias de SEO. Mi enfoque se centra en la segmentación del mercado y la personalización del mensaje, buscando siempre maximizar el impacto de cada acción de marketing. Estoy comprometida con la innovación en el marketing digital y estoy emocionada de colaborar en proyectos que impulsen el crecimiento de las marcas. ¡Contáctame y llevemos tu presencia en línea al siguiente nivel!", "https://example.com/image_monica.jpg", 100000 },
                    { new Guid("87dbaf90-f343-423e-9f14-e124fd145730"), "¡Hola! Soy Ana, una fotógrafa profesional con una pasión por capturar momentos memorables y contar historias a través de imágenes. Con más de 6 años de experiencia en fotografía, he trabajado en una variedad de proyectos, desde sesiones de retratos hasta cobertura de eventos especiales. Mi enfoque se centra en la creatividad y la sensibilidad artística, buscando siempre la belleza y el significado en cada fotografía. Estoy comprometida con la excelencia técnica y estoy emocionada de colaborar en proyectos que celebren la diversidad y la creatividad visual. ¡Contáctame y juntos creemos imágenes que perduren para siempre!", "https://example.com/image_ana.jpg", 85000 },
                    { new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473"), "Ana Gomez es una desarrolladora front-end experta en React y Angular, con una sólida trayectoria en la creación de interfaces de usuario atractivas y funcionales. Con más de 8 años de experiencia en el campo, Ana ha trabajado en diversos proyectos innovadores, siempre enfocándose en la usabilidad y la experiencia del usuario. Su habilidad para traducir los requisitos del cliente en soluciones técnicas efectivas es destacable.", "https://example.com/image_ana.jpg", 55000 },
                    { new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2"), "¡Hola! Soy Mónica García, una psicóloga clínica comprometida con el bienestar emocional y mental de mis pacientes. Con más de 8 años de experiencia en el campo, he trabajado con personas de todas las edades y condiciones para ayudarles a superar desafíos emocionales y mejorar su calidad de vida. Mi enfoque se centra en la terapia cognitivo-conductual y en encontrar soluciones prácticas que promuevan el crecimiento personal y el bienestar emocional. Estoy emocionada de colaborar en proyectos que me permitan aplicar mis conocimientos y habilidades para ayudar a otros a vivir vidas más saludables y satisfactorias. ¡Contáctame y comencemos juntos el camino hacia el bienestar!", "https://example.com/image_monica.jpg", 85000 },
                    { new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df"), "¡Hola! Soy Alejandra Hernández, una ingeniera de software apasionada por la creación de soluciones innovadoras y eficientes. Con más de 6 años de experiencia en desarrollo de software, he trabajado en una variedad de proyectos, desde aplicaciones móviles hasta sistemas empresariales. Mi enfoque se centra en el diseño de software robusto y escalable que cumpla con los requisitos del cliente y supere sus expectativas. Estoy comprometida con la mejora continua y estoy emocionada de colaborar en proyectos que me desafíen y me permitan seguir aprendiendo y creciendo profesionalmente. ¡Contáctame y trabajemos juntos para impulsar la innovación!", "https://example.com/image_alejandra.jpg", 110000 },
                    { new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6"), "¡Hola! Soy Antonio Alvarez, un desarrollador web con experiencia en la creación de sitios web y aplicaciones web dinámicas y funcionales. Con más de 5 años de experiencia en el campo, he trabajado en una variedad de proyectos que van desde pequeñas empresas hasta grandes corporaciones. Mi enfoque se centra en entender las necesidades del cliente y ofrecer soluciones personalizadas que superen sus expectativas. Estoy emocionado de trabajar en proyectos desafiantes que me permitan aplicar y mejorar mis habilidades. ¡Estoy listo para contribuir con mi experiencia y hacer una diferencia en tu equipo de desarrollo!", "https://example.com/image_antonio.jpg", 70000 },
                    { new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49"), "¡Hola! Soy Carlos Hernández, un arquitecto apasionado por el diseño sostenible y la planificación urbana. Con más de 8 años de experiencia en arquitectura, he trabajado en una variedad de proyectos, desde viviendas unifamiliares hasta grandes desarrollos urbanos. Mi enfoque se centra en la integración de prácticas sostenibles en el diseño arquitectónico, creando espacios que sean tanto estéticamente atractivos como respetuosos con el medio ambiente. Estoy comprometido con la mejora de la calidad de vida en las ciudades y estoy emocionado de colaborar en proyectos que promuevan un desarrollo urbano sostenible. ¡Contáctame y juntos diseñemos el futuro de nuestras ciudades!", "https://example.com/image_carlos.jpg", 140000 },
                    { new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8"), "Carlos Rodriguez es un desarrollador backend especializado en Java y el framework Spring, con más de 12 años de experiencia en la industria. Carlos se destaca por su capacidad para diseñar y optimizar sistemas backend complejos, asegurando la eficiencia y escalabilidad. Su experiencia abarca desde la creación de APIs robustas hasta la gestión de bases de datos, siempre con un enfoque en la solución de problemas y la mejora continua.", "https://example.com/image_carlos.jpg", 65000 },
                    { new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7"), "¡Hola! Soy Pablo, un consultor de marketing digital con una pasión por ayudar a las marcas a alcanzar su máximo potencial en línea. Con más de 5 años de experiencia en marketing digital, he trabajado en una variedad de proyectos, desde estrategias de redes sociales hasta campañas de PPC. Mi enfoque se centra en la analítica y la optimización, buscando siempre maximizar el ROI de cada acción de marketing. Estoy comprometido con la excelencia en el marketing digital y estoy emocionado de colaborar en proyectos que impulsen el crecimiento de las marcas. ¡Contáctame y llevemos tu estrategia digital al siguiente nivel!", "https://example.com/image_pablo.jpg", 90000 },
                    { new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633"), "¡Hola! Soy Camila Sánchez, una psicóloga clínica comprometida con el bienestar emocional y mental de mis pacientes. Con más de 7 años de experiencia en el campo, he trabajado en una variedad de entornos, desde hospitales hasta consultorios privados. Mi enfoque se centra en proporcionar terapia individualizada y centrada en el paciente que aborde sus necesidades específicas y promueva el crecimiento personal. Estoy comprometida con la empatía y la compasión en mi práctica clínica y estoy emocionada de colaborar en proyectos que me permitan ayudar a las personas a superar sus desafíos emocionales y alcanzar su máximo potencial. ¡Contáctame y comencemos este viaje de autodescubrimiento juntos!", "https://example.com/image_camila.jpg", 95000 },
                    { new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675"), "¡Hola! Soy Sara Perez, una apasionada del marketing digital con experiencia en estrategias de contenido, redes sociales y SEO. A lo largo de mi carrera, he trabajado en diversas campañas que han generado resultados significativos para mis clientes. Mi enfoque se centra en comprender las necesidades del cliente y crear estrategias personalizadas que impulsen el compromiso y la conversión. Con un ojo para el detalle y una mentalidad analítica, estoy constantemente buscando formas de optimizar y mejorar el rendimiento de las campañas. ¡Estoy emocionada de colaborar contigo y ayudarte a alcanzar tus objetivos de marketing digital!", "https://example.com/image_sara.jpg", 60000 },
                    { new Guid("b2269673-9d47-471a-a958-24160608ae82"), "¡Hola! Soy Isabel Hernandez, una diseñadora de moda con una pasión por la creación de prendas elegantes y atemporales. Con más de 8 años de experiencia en la industria, he trabajado en una variedad de proyectos que abarcan desde moda casual hasta alta costura. Mi enfoque se centra en la calidad, la originalidad y la atención al detalle, y estoy comprometida a ofrecer productos que no solo sean hermosos, sino también cómodos y funcionales. Estoy emocionada de colaborar en proyectos que me permitan expresar mi creatividad y contribuir al mundo de la moda. ¡Contáctame y hagamos magia juntos!", "https://example.com/image_isabel.jpg", 75000 },
                    { new Guid("b7d7964a-3f03-4930-a23d-59d90711f002"), "¡Hola! Soy Elena, una fotógrafa profesional con una pasión por capturar momentos inolvidables. Con más de 8 años de experiencia en fotografía, he trabajado en una variedad de proyectos, desde retratos hasta fotografía de eventos. Mi enfoque se centra en la creatividad y la composición, buscando siempre crear imágenes que cuenten una historia única. Estoy comprometida con la excelencia en la fotografía y estoy emocionada de colaborar en proyectos que celebren la belleza del mundo que nos rodea. ¡Contáctame y juntos capturemos momentos que perduren para siempre!", "https://example.com/image_elena.jpg", 95000 },
                    { new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb"), "Luis Fernandez es un diseñador UX/UI con experiencia en la creación de interfaces intuitivas y atractivas. Su enfoque centrado en el usuario y su atención al detalle se reflejan en sus diseños, que han sido elogiados por su funcionalidad y estética. Luis es un colaborador comprometido y proactivo, siempre buscando oportunidades para mejorar la experiencia del usuario. Con una sólida comprensión de los principios de diseño y una habilidad para comunicarse eficazmente, Luis es capaz de transformar las ideas en experiencias digitales impactantes.", "https://example.com/image_luis.jpg", 50000 },
                    { new Guid("ba694638-8e1c-4398-a3db-50b879ea1414"), "¡Hola! Soy Roberto Hidalgo, un desarrollador full-stack con experiencia en la creación de aplicaciones web y móviles. Con más de 8 años de experiencia en el campo, he trabajado en una variedad de proyectos que van desde startups hasta grandes empresas. Mi enfoque se centra en entender las necesidades del usuario y ofrecer soluciones eficientes y escalables que mejoren su experiencia. Estoy emocionado de trabajar en proyectos desafiantes que me permitan aplicar y mejorar mis habilidades como desarrollador. ¡Estoy listo para enfrentar cualquier desafío y hacer una contribución significativa a tu equipo!", "https://example.com/image_roberto.jpg", 65000 },
                    { new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c"), "¡Hola! Soy Fernando Gómez, un abogado especializado en derecho corporativo y empresarial. Con más de 8 años de experiencia en el campo, he asesorado a empresas en una variedad de asuntos legales, desde fusiones y adquisiciones hasta litigios comerciales. Mi enfoque se centra en proporcionar soluciones legales estratégicas que protejan los intereses de mis clientes y impulsen el crecimiento de sus negocios. Estoy comprometido con la excelencia en la práctica del derecho y estoy emocionado de colaborar en proyectos que me permitan aplicar mis conocimientos y habilidades para ayudar a las empresas a alcanzar sus objetivos comerciales. ¡Contáctame y trabajemos juntos para asegurar tu éxito empresarial!", "https://example.com/image_fernando.jpg", 120000 },
                    { new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7"), "¡Hola! Soy Rafael Martinez, un consultor de negocios con experiencia en estrategia empresarial y gestión de proyectos. Con más de 6 años de experiencia en el campo, he trabajado con una variedad de empresas para identificar oportunidades de crecimiento y mejorar la eficiencia operativa. Mi enfoque se centra en comprender las necesidades específicas de cada cliente y desarrollar soluciones prácticas y personalizadas que generen resultados tangibles. Estoy emocionado de colaborar en proyectos desafiantes que me permitan aplicar y expandir mis habilidades como consultor. ¡Estoy listo para enfrentar cualquier desafío y ayudarte a llevar tu negocio al siguiente nivel!", "https://example.com/image_rafael.jpg", 80000 },
                    { new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d"), "¡Hola! Soy Ricardo Morales, un ingeniero mecánico con experiencia en el diseño y la fabricación de sistemas mecánicos innovadores. Con más de 8 años de experiencia en la industria, he trabajado en una variedad de proyectos, desde automoción hasta energía renovable. Mi enfoque se centra en la eficiencia y la sostenibilidad, diseñando sistemas que sean tanto funcionales como respetuosos con el medio ambiente. Estoy comprometido con la excelencia en el diseño y la ingeniería y estoy emocionado de colaborar en proyectos que me permitan aplicar mi experiencia y conocimientos. ¡Contáctame y trabajemos juntos para impulsar la innovación en la industria!", "https://example.com/image_ricardo.jpg", 130000 },
                    { new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206"), "¡Hola! Soy Paula Pérez, una abogada especializada en derecho laboral con experiencia en la defensa de los derechos de los trabajadores. Con más de 8 años de experiencia en el campo, he representado a clientes en una variedad de casos, desde despidos injustificados hasta reclamaciones de salarios y beneficios. Mi enfoque se centra en proporcionar asesoramiento legal integral y estratégico que proteja los intereses de mis clientes y garantice un trato justo en el lugar de trabajo. Estoy comprometida con la justicia y la equidad y estoy emocionada de poder ayudarte a resolver tus problemas legales laborales. ¡Contáctame y defendamos tus derechos juntos!", "https://example.com/image_paula.jpg", 80000 },
                    { new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b"), "¡Hola! Soy Gustavo Martínez, un arquitecto con pasión por el diseño creativo y funcional. Con más de 8 años de experiencia en la industria de la construcción, he trabajado en una variedad de proyectos, desde viviendas unifamiliares hasta complejos comerciales. Mi enfoque se centra en la integración de la estética y la funcionalidad para crear espacios arquitectónicos que mejoren la calidad de vida de las personas. Estoy comprometido con la sostenibilidad y la innovación en el diseño y estoy emocionado de colaborar en proyectos que me permitan aplicar mi experiencia y creatividad. ¡Contáctame y trabajemos juntos para hacer realidad tus sueños arquitectónicos!", "https://example.com/image_gustavo.jpg", 120000 },
                    { new Guid("c5f0f42f-255f-400d-b657-bed222ec9903"), "¡Hola! Soy Luis Miguel, un contador con experiencia en la gestión financiera y la planificación fiscal. Con más de 8 años de experiencia en el campo, he trabajado en una variedad de industrias, desde la banca hasta la consultoría financiera. Mi enfoque se centra en proporcionar asesoramiento financiero estratégico que ayude a las empresas a alcanzar sus objetivos comerciales y financieros. Estoy comprometido con la integridad y la precisión en cada proyecto que emprendo y estoy emocionado de colaborar en proyectos que me permitan aplicar mi experiencia y conocimientos. ¡Contáctame y trabajemos juntos para optimizar tus finanzas!", "https://example.com/image_luismiguel.jpg", 95000 },
                    { new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9"), "¡Hola! Soy Teresa Díaz, una terapeuta ocupacional comprometida con el bienestar y la calidad de vida de mis pacientes. Con más de 8 años de experiencia en el campo, he trabajado con personas de todas las edades y condiciones para ayudarles a recuperar habilidades motoras y funcionales y mejorar su independencia en actividades diarias. Mi enfoque se centra en la atención personalizada y en encontrar soluciones prácticas que mejoren la calidad de vida de mis pacientes. Estoy emocionada de colaborar en proyectos que me permitan aplicar mis conocimientos y habilidades para ayudar a otros a alcanzar su máximo potencial. ¡Contáctame y comencemos juntos el camino hacia la recuperación y el bienestar!", "https://example.com/image_teresa.jpg", 95000 },
                    { new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978"), "¡Hola! Soy Laura Hernandez, una entusiasta del diseño gráfico con una pasión por la creatividad y la innovación. Con más de 5 años de experiencia en el campo, he trabajado en una variedad de proyectos, desde diseño de logotipos hasta campañas publicitarias completas. Mi enfoque se centra en crear diseños visualmente impactantes que no solo sean estéticamente agradables, sino también funcionales y efectivos para transmitir el mensaje deseado. Siempre estoy buscando desafíos emocionantes que me permitan expandir mis habilidades y aprender nuevas técnicas. ¡Estoy emocionada de colaborar en tu próximo proyecto y llevar tus ideas a la vida! ¡Contáctame y comencemos a crear algo increíble juntos!", "https://example.com/image_laura.jpg", 55000 },
                    { new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26"), "¡Hola! Soy Patricia Flores, una diseñadora de moda con una pasión por la creación de prendas únicas y elegantes. Con más de 8 años de experiencia en la industria, he trabajado en una variedad de proyectos que abarcan desde diseño de alta costura hasta ropa casual y deportiva. Mi enfoque se centra en la calidad, la originalidad y la innovación, y estoy comprometida a ofrecer productos que no solo sean hermosos, sino también cómodos y funcionales. Estoy emocionada de colaborar en proyectos que me permitan expresar mi creatividad y contribuir al mundo de la moda. ¡Contáctame y hagamos magia juntos!", "https://example.com/image_patricia.jpg", 75000 },
                    { new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7"), "¡Hola! Soy Roberto Morales, un arquitecto apasionado por el diseño innovador y sostenible. Con más de 10 años de experiencia en la industria, he liderado proyectos que van desde edificios residenciales hasta complejos comerciales y urbanizaciones. Mi enfoque se centra en la integración de la arquitectura con el entorno natural y la creación de espacios que promuevan el bienestar y la sostenibilidad. Estoy emocionado de colaborar en proyectos que me permitan aplicar mi experiencia y creatividad para crear lugares inspiradores y funcionales. ¡Contáctame y hagamos realidad tus ideas arquitectónicas!", "https://example.com/image_roberto.jpg", 90000 },
                    { new Guid("cd88e529-eedb-42c5-a88d-384f5976a754"), "¡Hola! Soy Pablo Martinez, un diseñador gráfico con una pasión por la creatividad y el arte visual. Con más de 7 años de experiencia en el campo, he trabajado en una variedad de proyectos que abarcan desde diseño de logotipos y branding hasta ilustraciones y diseño editorial. Mi enfoque se centra en capturar la esencia de cada proyecto y transmitirlo a través de diseños únicos y atractivos. Estoy constantemente buscando nuevas inspiraciones y tendencias para mejorar mi trabajo y ofrecer resultados excepcionales a mis clientes. ¡Estoy emocionado de colaborar en tu próximo proyecto y ayudarte a alcanzar tus objetivos de diseño!", "https://example.com/image_pablo.jpg", 60000 },
                    { new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7"), "¡Hola! Soy Paola Díaz, una abogada comprometida con la justicia y la defensa de los derechos humanos. Con más de 7 años de experiencia en el campo del derecho, me especializo en derecho laboral y derecho civil. He representado con éxito a clientes en una variedad de casos, desde disputas laborales hasta reclamaciones de daños personales. Mi enfoque se centra en proporcionar asesoramiento legal compasivo y efectivo que resuelva los problemas de mis clientes de manera justa y equitativa. Estoy comprometida con la ética y la profesionalidad en mi práctica legal y estoy emocionada de colaborar en proyectos que promuevan la justicia y la igualdad. ¡Contáctame y trabajemos juntos para proteger tus derechos!", "https://example.com/image_paola.jpg", 110000 },
                    { new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd"), "¡Hola! Soy Pedro, un ingeniero de software con una pasión por la programación y el desarrollo de aplicaciones innovadoras. Con más de 5 años de experiencia en desarrollo de software, he trabajado en una variedad de proyectos, desde aplicaciones móviles hasta sistemas de gestión empresarial. Mi enfoque se centra en la calidad del código y la eficiencia del desarrollo, asegurándome de que cada producto cumpla con los más altos estándares de rendimiento y usabilidad. Estoy comprometido con la mejora continua y estoy emocionado de colaborar en proyectos que desafíen mis habilidades técnicas. ¡Contáctame y llevemos tus ideas al siguiente nivel!", "https://example.com/image_pedro.jpg", 90000 },
                    { new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85"), "Leonel Esquivel es un desarrollador full-stack con más de 10 años de experiencia en el desarrollo de aplicaciones utilizando C# y .NET. Es reconocido por su capacidad para diseñar y mantener sistemas robustos y escalables, y tiene un historial comprobado de trabajo exitoso en proyectos de gran envergadura. Leonel es un profesional proactivo con habilidades excepcionales en la resolución de problemas y un enfoque meticuloso en la calidad del código.", "https://example.com/image_leonel.jpg", 60000 },
                    { new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16"), "¡Hola! Soy David, un diseñador gráfico con una pasión por la creatividad y la expresión visual. Con más de 6 años de experiencia en diseño gráfico, he trabajado en una variedad de proyectos, desde branding corporativo hasta diseño de interfaces de usuario. Mi enfoque se centra en la estética y la funcionalidad, buscando siempre encontrar el equilibrio perfecto entre la forma y la función. Estoy comprometido con la innovación en el diseño y estoy emocionado de colaborar en proyectos que desafíen mi creatividad. ¡Contáctame y llevemos tu marca al siguiente nivel visual!", "https://example.com/image_david.jpg", 95000 },
                    { new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241"), "¡Hola! Soy Roberto López, un abogado especializado en derecho laboral con una pasión por la justicia y la equidad en el trabajo. Con más de 7 años de experiencia en derecho laboral, he representado a trabajadores y empleadores en una variedad de casos, desde despidos injustificados hasta conflictos sindicales. Mi enfoque se centra en la defensa de los derechos laborales y la resolución eficiente de conflictos, buscando siempre alcanzar acuerdos justos para todas las partes involucradas. Estoy comprometido con la defensa de los derechos humanos y estoy emocionado de colaborar en proyectos que promuevan un ambiente laboral justo y equitativo. ¡Contáctame y juntos defendamos tus derechos!", "https://example.com/image_roberto.jpg", 90000 },
                    { new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090"), "¡Hola! Soy Andres Romero, un desarrollador de software con experiencia en el diseño y desarrollo de aplicaciones móviles y web. Con más de 6 años de experiencia en el campo, he trabajado en una variedad de proyectos que van desde aplicaciones móviles para startups hasta soluciones empresariales complejas. Mi enfoque se centra en entender las necesidades del usuario y ofrecer soluciones intuitivas y efectivas que mejoren su experiencia. Estoy emocionado de trabajar en proyectos desafiantes que me permitan aplicar y mejorar mis habilidades como desarrollador. ¡Estoy listo para enfrentar cualquier desafío y hacer una contribución significativa a tu equipo!", "https://example.com/image_andres.jpg", 80000 },
                    { new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a"), "¡Hola! Soy Felipe López, un desarrollador web con una pasión por crear experiencias digitales excepcionales. Con más de 4 años de experiencia en el desarrollo de sitios web y aplicaciones, he trabajado en una variedad de proyectos, desde sitios de comercio electrónico hasta aplicaciones empresariales. Mi enfoque se centra en la usabilidad y el rendimiento, asegurándome de que cada proyecto cumpla con los más altos estándares de calidad. Estoy comprometido con el aprendizaje continuo y la mejora de mis habilidades y estoy emocionado de colaborar en proyectos innovadores que desafíen mis capacidades. ¡Contáctame y llevemos tu presencia en línea al siguiente nivel!", "https://example.com/image_felipe.jpg", 95000 }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "SkillId", "Name" },
                values: new object[,]
                {
                    { 1, "Java" },
                    { 2, "Javascript" },
                    { 3, "C#" },
                    { 4, "Python" },
                    { 5, "Ruby" },
                    { 6, "PHP" },
                    { 7, "Swift" },
                    { 8, "Go" },
                    { 9, "Rust" },
                    { 10, "Kotlin" },
                    { 11, "TypeScript" },
                    { 12, "C++" },
                    { 13, "Scala" },
                    { 14, "Perl" },
                    { 15, "R" },
                    { 16, "MATLAB" },
                    { 17, "Haskell" },
                    { 18, "Cobol" },
                    { 19, "Lisp" },
                    { 20, "Prolog" },
                    { 21, "Ada" },
                    { 22, "Fortran" },
                    { 23, "Assembly (x86, ARM)" },
                    { 24, ".NET" },
                    { 25, "Spring" },
                    { 26, "Django" },
                    { 27, "React" },
                    { 28, "Angular" },
                    { 29, "Vue.js" },
                    { 30, "Node.js" },
                    { 31, "Express.js" },
                    { 32, "Flask" },
                    { 33, "Ruby on Rails" },
                    { 34, "Laravel" },
                    { 35, "Symfony" },
                    { 36, "Hibernate" },
                    { 37, "Xamarin" },
                    { 38, "Unity" },
                    { 39, "TensorFlow" },
                    { 40, "PyTorch" },
                    { 41, "Adobe Photoshop" },
                    { 42, "Adobe Illustrator" },
                    { 43, "Adobe InDesign" },
                    { 44, "Sketch" },
                    { 45, "CorelDRAW" },
                    { 46, "AutoCAD" },
                    { 47, "Revit" },
                    { 48, "Legal Research" },
                    { 49, "Litigation" },
                    { 50, "Contract Drafting" },
                    { 51, "Microsoft Office" },
                    { 52, "Excel" },
                    { 53, "Word" },
                    { 54, "PowerPoint" },
                    { 55, "Outlook" },
                    { 56, "Adobe Premiere Pro" },
                    { 57, "Final Cut Pro" },
                    { 58, "Avid Media Composer" },
                    { 59, "Blender" },
                    { 60, "Maya" },
                    { 61, "3ds Max" },
                    { 62, "ZBrush" },
                    { 63, "SketchUp" },
                    { 64, "Illustration" },
                    { 65, "Typography" },
                    { 66, "Digital Painting" },
                    { 67, "User Experience (UX) Design" },
                    { 68, "User Interface (UI) Design" },
                    { 69, "Wireframing" },
                    { 70, "Prototyping" },
                    { 71, "Information Architecture" },
                    { 72, "Interaction Design" },
                    { 73, "Brand Identity" },
                    { 74, "Print Design" },
                    { 75, "Packaging Design" },
                    { 76, "Logo Design" },
                    { 77, "Motion Graphics" },
                    { 78, "2D Animation" },
                    { 79, "3D Animation" },
                    { 80, "Character Animation" },
                    { 81, "Legal Writing" },
                    { 82, "Corporate Law" },
                    { 83, "Intellectual Property Law" },
                    { 84, "Family Law" },
                    { 85, "Environmental Law" },
                    { 86, "Immigration Law" },
                    { 87, "Real Estate Law" },
                    { 88, "Bankruptcy Law" },
                    { 89, "Criminal Law" },
                    { 90, "Health Law" },
                    { 91, "Tax Law" },
                    { 92, "International Law" },
                    { 93, "Administrative Law" },
                    { 94, "Legal Compliance" },
                    { 95, "Legal Consulting" },
                    { 96, "Legal Research" },
                    { 97, "Legal Writing" },
                    { 98, "Legal Analysis" },
                    { 99, "Legal Documentation" },
                    { 100, "Data Entry" },
                    { 101, "Typing" },
                    { 102, "Proofreading" },
                    { 103, "Document Formatting" },
                    { 104, "Transcription" },
                    { 105, "Virtual Assistance" },
                    { 106, "Customer Service" },
                    { 107, "Email Handling" },
                    { 108, "Calendar Management" },
                    { 109, "Travel Arrangements" },
                    { 110, "Event Planning" },
                    { 111, "Research" },
                    { 112, "Social Media Management" },
                    { 113, "Content Creation" },
                    { 114, "Digital Marketing" },
                    { 115, "Search Engine Optimization (SEO)" },
                    { 116, "Search Engine Marketing (SEM)" },
                    { 117, "Email Marketing" },
                    { 118, "Graphic Design" },
                    { 119, "Web Design" },
                    { 120, "Video Editing" },
                    { 121, "Audio Editing" },
                    { 122, "Photography" },
                    { 123, "Videography" },
                    { 124, "Photo Editing" },
                    { 125, "Image Retouching" },
                    { 126, "Color Grading" },
                    { 127, "Storyboarding" },
                    { 128, "Scriptwriting" },
                    { 129, "Creative Writing" },
                    { 130, "Copywriting" },
                    { 131, "Technical Writing" },
                    { 132, "Editing" },
                    { 133, "Translation" },
                    { 134, "Localization" },
                    { 135, "Subtitling" }
                });

            migrationBuilder.InsertData(
                table: "StudyType",
                columns: new[] { "StudyTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Primaria" },
                    { 2, "Secundaria" },
                    { 3, "Terciario" },
                    { 4, "Universitario" },
                    { 5, "Posgrado" },
                    { 6, "Master" },
                    { 7, "Doctorado" },
                    { 8, "Curso" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Experience_UserId",
                table: "Experience",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ResumeSkill_SkillId",
                table: "ResumeSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_StudyTypeId",
                table: "Study",
                column: "StudyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_UserId",
                table: "Study",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experience");

            migrationBuilder.DropTable(
                name: "ResumeSkill");

            migrationBuilder.DropTable(
                name: "Study");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Resume");

            migrationBuilder.DropTable(
                name: "StudyType");
        }
    }
}
