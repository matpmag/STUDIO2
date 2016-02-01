DELETE FROM table_Class
DBCC CHECKIDENT(table_Class,RESEED,0);
DELETE FROM table_Role
DBCC CHECKIDENT(table_Role,RESEED,0);

INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('YOGA',1,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('PILATES',1,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('YOGA',2,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('TAICHI',1,'GYM')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('YOGA',3,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('KEEPFIT',1,'FSUITE')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('PILATES',1,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('YOGA',2,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('KEEPFIT',1,'FSUITE')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('PILATES',3,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('JUDO',1,'GYM')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('YOGA',1,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('TAICHI',2,'GYM')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('YOGA',3,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('YOGA',1,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('PILATES',2,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('JUDO',2,'GYM')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('KEEPFIT',2,'FSUITE')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('PILATES',1,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('KEEPFIT',2,'FSUITE')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('TAICHI',3,'GYM')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('PILATES',2,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('JUDO',3,'GYM')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('PILATES',2,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('YOGA',3,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('TAICHI',3,'GYM')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('YOGA',2,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('TAICHI',1,'GYM')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('KEEPFIT',3,'FSUITE')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('JUDO',2,'GYM')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('YOGA',2,'YOGA')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('JUDO',1,'GYM')
INSERT INTO table_Class([Field],[Level],[Room]) VALUES ('PILATES',3,'YOGA')

INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','07:30','12:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','07:30','12:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','12:30','17:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','12:30','17:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','17:30','21:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','17:30','21:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','07:30','12:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','07:30','12:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','12:30','17:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','12:30','17:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','17:30','21:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','17:30','21:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','07:30','12:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','07:30','12:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','12:30','17:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','12:30','17:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','17:30','21:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','17:30','21:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','07:30','12:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','07:30','12:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','12:30','17:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','12:30','17:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','17:30','21:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','17:30','21:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','07:30','12:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','07:30','12:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','12:30','17:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','12:30','17:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','17:30','21:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','17:30','21:30','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','07:30','12:00','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','07:30','12:00','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','12:00','16:00','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','12:00','16:00','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','16:00','20:00','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','16:00','20:00','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SUN','08:00','13:00','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SUN','08:00','13:00','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SUN','13:00','18:00','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SUN','13:00','18:00','FLOAT','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('MON','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('TUE','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('WED','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('THU','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','07:30','12:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','12:30','17:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('FRI','17:30','21:30','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','07:30','12:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','07:30','12:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','07:30','12:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','07:30','12:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','12:00','16:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','12:00','16:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','12:00','16:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','12:00','16:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','16:00','20:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','16:00','20:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','16:00','20:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SAT','16:00','20:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SUN','08:00','13:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SUN','08:00','13:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SUN','08:00','13:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SUN','08:00','13:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SUN','13:00','18:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SUN','13:00','18:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SUN','13:00','18:00','GYM','0','100')
INSERT INTO [table_Role]([Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('SUN','13:00','18:00','GYM','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('1','MON','09:00','10:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('1','MON','09:00','10:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('2','MON','11:00','12:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('2','MON','09:00','10:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('3','MON','15:00','16:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('3','MON','15:00','16:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('4','MON','16:00','17:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('4','MON','15:00','16:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('5','MON','19:00','20:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('5','MON','19:00','20:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('6','MON','20:00','21:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('6','MON','20:00','21:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('7','TUE','10:00','11:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('7','TUE','10:00','11:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('8','TUE','11:00','12:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('8','TUE','11:00','12:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('9','TUE','14:00','15:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('9','TUE','14:00','15:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('10','TUE','15:00','16:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('10','TUE','15:00','16:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('11','TUE','18:00','19:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('11','TUE','18:00','19:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('12','TUE','19:00','20:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('12','TUE','19:00','20:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('13','WED','11:30','12:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('13','WED','11:30','12:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('14','WED','12:30','13:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('14','WED','12:30','13:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('15','WED','14:30','15:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('15','WED','14:30','15:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('16','WED','15:30','16:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('16','WED','15:30','16:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('17','WED','17:30','18:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('17','WED','17:30','18:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('18','WED','18:30','19:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('18','WED','18:30','19:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('19','THU','10:30','11:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('19','THU','10:30','11:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('20','THU','11:30','12:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('20','THU','11:30','12:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('21','THU','13:30','14:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('21','THU','13:30','14:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('22','THU','14:30','15:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('22','THU','14:30','15:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('23','THU','17:30','18:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('23','THU','17:30','18:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('24','THU','18:30','19:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('24','THU','18:30','19:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('25','FRI','11:30','12:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('25','FRI','11:30','12:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('26','FRI','12:30','13:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('26','FRI','12:30','13:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('27','FRI','15:00','16:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('27','FRI','15:00','16:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('28','FRI','16:00','17:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('28','FRI','16:00','17:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('29','FRI','17:30','18:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('29','FRI','17:30','18:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('30','FRI','18:30','19:30','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('30','FRI','18:30','19:30','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('31','SAT','09:00','10:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('31','SAT','09:00','10:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('32','SAT','10:00','11:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('32','SAT','10:00','11:00','ASSIST','0','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('33','SAT','11:00','12:00','INSTRUCT','1','100')
INSERT INTO [table_Role]([ClassID],[Day],[StartTime],[EndTime],[Position],[QualificationRequired],[StaffID]) VALUES ('33','SAT','11:00','12:00','ASSIST','0','100')