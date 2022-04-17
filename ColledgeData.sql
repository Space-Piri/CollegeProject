use CourseManager
delete from TeacherCourseTheme
DBCC CHECKIDENT ('TeacherCourseTheme', RESEED, 0);
delete from User_Types
DBCC CHECKIDENT ('User_Types', RESEED, 0);
delete from Courses
DBCC CHECKIDENT ('Courses', RESEED, 0);
delete from TeacherCourse
DBCC CHECKIDENT ('TeacherCourse', RESEED, 0);
delete from TeacherDiscipline
DBCC CHECKIDENT ('TeacherDiscipline', RESEED, 0);
delete from Teachers
DBCC CHECKIDENT ('Teachers', RESEED, 0);
delete from Discipline
DBCC CHECKIDENT ('Discipline', RESEED, 0);
delete from Couples
DBCC CHECKIDENT ('Couples', RESEED, 0);
delete from Specialty
DBCC CHECKIDENT ('Specialty', RESEED, 0);
delete from Groups
DBCC CHECKIDENT ('Groups', RESEED, 0);
delete from Student
DBCC CHECKIDENT ('Student', RESEED, 0);
delete from Users
DBCC CHECKIDENT ('Users', RESEED, 0);
delete from Days
DBCC CHECKIDENT ('Days', RESEED, 0);
delete from DayTypes
DBCC CHECKIDENT ('DayTypes', RESEED, 0);

delete from TeacherCourseTheme
DBCC CHECKIDENT ('TeacherCourseTheme', RESEED, 0);
delete from User_Types
DBCC CHECKIDENT ('User_Types', RESEED, 0);
delete from Courses
DBCC CHECKIDENT ('Courses', RESEED, 0);
delete from TeacherCourse
DBCC CHECKIDENT ('TeacherCourse', RESEED, 0);
delete from TeacherDiscipline
DBCC CHECKIDENT ('TeacherDiscipline', RESEED, 0);
delete from Teachers
DBCC CHECKIDENT ('Teachers', RESEED, 0);
delete from Discipline
DBCC CHECKIDENT ('Discipline', RESEED, 0);
delete from Couples
DBCC CHECKIDENT ('Couples', RESEED, 0);
delete from Specialty
DBCC CHECKIDENT ('Specialty', RESEED, 0);
delete from Groups
DBCC CHECKIDENT ('Groups', RESEED, 0);
delete from Student
DBCC CHECKIDENT ('Student', RESEED, 0);
delete from Users
DBCC CHECKIDENT ('Users', RESEED, 0);
delete from Days
DBCC CHECKIDENT ('Days', RESEED, 0);
delete from DayTypes
DBCC CHECKIDENT ('DayTypes', RESEED, 0);

insert into User_Types values ('Admin')
insert into User_Types values ('User')
insert into User_Types values ('Teacher')

insert into Users values ('Бочаров Марк Александрович', 1,'markA', 'xTfpCG')
insert into Users values ('Комарова Вероника Артёмовна',1,'veraA','LL1XWb')

insert into Users values ('Агеева Александра Макаровна',3,'alexM','tDaIMk')
insert into Users values ('Казакова Дарья Борисовна',3,'DashaB','ERkc2R')
insert into Users values ('Миронов Александр Антонович',3,'AlexA','izIXoq')
insert into Users values ('Суслова Милана Святославовна',3,'MilanaS','3NLXXu')
insert into Users values ('Юдин Максим Алексеевич',3,'MaxA','kUaKaO')
insert into Users values ('Демидова Варвара Олеговна',3,'VarvaraO','VucGe1')
insert into Users values ('Горячева Ульяна Владиславовна',3,'UlayV','OCk5Nh')

insert into Teachers select Id from Users where Id_Type = 3 or Id_Type = 1

insert into Users values ('Никольский Никита Ярославович',2,'snatch','ps3VfB')
insert into Users values ('Беляев Елисей Александрович',2,'goblin','kyq96E')
insert into Users values ('Румянцев Тимофей Григорьевич',2,'useless','Qnrp14')
insert into Users values ('Петров Дмитрий Даниилович',2,'DmitriD','JIse6k')
insert into Users values ('Козлова Виктория Александровна',2,'ViktoriaA','rEhdTY')
insert into Users values ('Белов Арсений Саввич',2,'ArseniyS','JDhoOn')
insert into Users values ('Семенова Дарья Семёновна',2,'DashaS','6VeOTa')
insert into Users values ('Цветкова Мария Михайловна',2,'MariaM','tWTiMw')
insert into Users values ('Бессонова Елизавета Макаровна',2,'LizaM','qEK0we')
insert into Users values ('Артемова Надежда Дмитриевна',2,'NadezdaD','7GPDry')

insert into Users values ('Гусева Варвара Ивановна',2,'VarvaraI','Wrpyrn')
insert into Users values ('Курочкина Яна Александровна',2,'YanaA','HvyLBi')
insert into Users values ('Зверев Руслан Никитич',2,'RuslanN','iCEmvy')
insert into Users values ('Бородин Ярослав Владимирович',2,'YaroslavV','hfDe8R')
insert into Users values ('Демидов Григорий Сергеевич',2,'Grigoriy','D69tlt')
insert into Users values ('Киселева Надежда Всеволодовна',2,'NadezdaV','BT29PF')
insert into Users values ('Лебедев Марк Ильич',2,'MarkI','HWjnVC')
insert into Users values ('Богданов Арсений Никитич',2,'ArseniyN','tC2JOR')
insert into Users values ('Сорокин Александр Александрович',2,'AlesandrA','gbBk4N')
insert into Users values ('Потапова Любовь Мирославовна',2,'LubovM','BHcGeB')

insert into Courses values ('Математика 10-11 класс','СП4 314','2021.09.10','2022.09.10',180,110)
insert into Courses values ('Астрономия','СП4 402','2021.11.01','2022.03.20',48,34)
insert into Courses values ('Web программирование','СП4 318','2022.04.01','2022.07.01',80,30)
insert into Courses values ('Технологии металлообработки','СП1 310','2022.01.01','2022.05.01',100,45)

insert into TeacherCourse values (1,1,110,0)
insert into TeacherCourse values (2,1,110,0)
insert into TeacherCourse values (3,1,110,0)

insert into TeacherCourse values (3,2,34,0)
insert into TeacherCourse values (4,2,34,0)
insert into TeacherCourse values (5,2,34,0)

insert into TeacherCourseTheme values (1,'Тригонометрические функции')
insert into TeacherCourseTheme values (1,'Тригонометрические уравнения')
insert into TeacherCourseTheme values (2,'Многогранники')
insert into TeacherCourseTheme values (2,'Производная')
insert into TeacherCourseTheme values (3,'Векторы в пространстве')

insert into TeacherCourseTheme values (4,'Звездные карты и координаты')
insert into TeacherCourseTheme values (5,'Эклиптика')
insert into TeacherCourseTheme values (6,'Солнце – ближайшая звезда')

insert into Specialty values ('09.02.07 Информационные системы и программирование')
insert into Specialty values ('10.02.05 Обеспечение информационной безопасности автоматизированных систем')

insert into Groups values ('402-ИСП-18', 1)
insert into Groups values ('204-ОИБ-20', 1)

insert into Student values(10,1)
insert into Student values(11,1)
insert into Student values(12,1)
insert into Student values(13,1)
insert into Student values(14,1)
insert into Student values(15,1)
insert into Student values(16,1)
insert into Student values(17,1)
insert into Student values(18,1)
insert into Student values(19,1)

insert into Student values(20,2)
insert into Student values(21,2)
insert into Student values(22,2)
insert into Student values(23,2)
insert into Student values(24,2)
insert into Student values(25,2)
insert into Student values(26,2)
insert into Student values(27,2)
insert into Student values(28,2)
insert into Student values(29,2)

insert into Discipline values ('Математика')
insert into Discipline values ('Русский язык')
insert into Discipline values ('Иностранный язык')
insert into Discipline values ('История')
insert into Discipline values ('Психология')
insert into Discipline values ('Биологоия')
insert into Discipline values ('Химия')
insert into Discipline values ('Физика')
insert into Discipline values ('Информатика')
insert into Discipline values ('География')
insert into Discipline values ('Web-программирование')
insert into Discipline values ('Основы проектирование баз данных')

insert into DayTypes values ('Каникулы')
insert into DayTypes values ('Выходной день')
insert into DayTypes values ('Праздничный день')
insert into DayTypes values ('Нет уроков')

insert into Days values ('09.05.2022', 1, 3)
insert into Days values ('09.05.2022', 2, 3)

insert into TeacherDiscipline values (1,1)
insert into TeacherDiscipline values (2,1)
insert into TeacherDiscipline values (3,2)
insert into TeacherDiscipline values (3,3)
insert into TeacherDiscipline values (4,4)
insert into TeacherDiscipline values (4,5)
insert into TeacherDiscipline values (5,6)
insert into TeacherDiscipline values (6,6)
insert into TeacherDiscipline values (7,7)
insert into TeacherDiscipline values (7,8)
insert into TeacherDiscipline values (7,9)
insert into TeacherDiscipline values (8,9)
insert into TeacherDiscipline values (8,10)
insert into TeacherDiscipline values (9,11)
insert into TeacherDiscipline values (9,12)
