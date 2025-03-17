DROP TABLE employees;

CREATE TABLE employees(
eid INTEGER PRIMARY KEY AUTOINCREMENT,
efname VARCHAR(40) NOT NULL,
elname VARCHAR(40) NOT NULL,
pnum VARCHAR(11)NOT NULL,
egender VARCHAR(20) NOT NULL,
eaddress VARCHAR(40)NOT NULL,
epostcode VARCHAR(8)NOT NULL,
eskills VARCHAR(200));
drop table employees;
drop table rota;
/*INSERT INTO employees(efname,elname,egender,pnum,eaddress,epostcode,eskills)
VALUES
('chistofer','columbus','12345678910','qwerty','qw3 4bvf',''),
('toast','greated','12345678911','uiopa','as3 5dd',''),
('e','','12345678912','sdfgh','bd4 4bf',''),
('g','h','12345678913','jklzx','lk4 5kd',''),
('j','k','12345678914','cvbnm','fd5 5ds',''),
('l','m','37492347723','asfdc','db5 6te',''),
('n','o','77127648683','gfdgd','yh6 9gh',''),
('p','q','40827547395','weorh','e42 0fd',''),
('r','s','13095767384','fanjf','kt4 3bn',''),
('','','','','','')
;*/

SELECT eid AS 'Employees ID', efname AS 'First Name', elname AS 'Last Name', pnum AS 'Phone Number', eaddress AS Address,epostcode AS Postcode,eskills AS Skills FROM employees;



CREATE TABLE store(
sid INTEGER PRIMARY KEY AUTOINCREMENT,
sname VARCHAR(30)NOT NULL,
slocation VARCHAR(20)NOT NULL,
saddress VARCHAR(30)NOT NULL,
spostcode VARCHAR(8)NOT NULL);

INSERT INTO store(sname,slocation,saddress,spostcode) VALUES
('Hobbs','Hounslow','kvsnsdv','hsdbfjd'),
('Engral','Twickenham','fsvssda','asdfdsd'),
('Smite','Southall','flsskdm','sadknlj');



CREATE TABLE shift(
hid INTEGER PRIMARY KEY AUTOINCREMENT,
stid INTEGER NOT NULL,
enid INTEGER NOT NULL,
FOREIGN KEY (stid) REFERENCES startshift(startid),
FOREIGN KEY (enid) REFERENCES endshift(endid));

/*INSERT INTO shift(stid,enid) VALUES
(,,);*/

CREATE TABLE startshift(
startid INTEGER PRIMARY KEY AUTOINCREMENT,
starthour VARCHAR NOT NULL);

INSERT INTO startshift(starthour)
VALUES
('00:00'),
('00:30'),
('01:00'),
('01:30'),
('02:00'),
('02:30'),
('03:00'),
('03:30'),
('04:00'),
('04:30'),
('05:00'),
('05:30'),
('06:00'),
('06:30'),
('07:00'),
('07:30'),
('08:00'),
('08:30'),
('09:00'),
('09:30'),
('10:00'),
('10:30'),
('11:00'),
('11:30'),
('12:00'),
('12:30'),
('13:00'),
('13:30'),
('14:00'),
('14:30'),
('15:00'),
('15:30'),
('16:00'),
('16:30'),
('17:00'),
('17:30'),
('18:00'),
('18:30'),
('19:00'),
('19:30'),
('20:00'),
('20:30'),
('21:00'),
('21:30'),
('22:00'),
('22:30'),
('23:00'),
('23:30');


CREATE TABLE endshift(
endid INTEGER PRIMARY KEY AUTOINCREMENT,
endhour VARCHAR NOT NULL);

INSERT INTO endshift(endhour)
VALUES
('00:00'),
('00:30'),
('01:00'),
('01:30'),
('02:00'),
('02:30'),
('03:00'),
('03:30'),
('04:00'),
('04:30'),
('05:00'),
('05:30'),
('06:00'),
('06:30'),
('07:00'),
('07:30'),
('08:00'),
('08:30'),
('09:00'),
('09:30'),
('10:00'),
('10:30'),
('11:00'),
('11:30'),
('12:00'),
('12:30'),
('13:00'),
('13:30'),
('14:00'),
('14:30'),
('15:00'),
('15:30'),
('16:00'),
('16:30'),
('17:00'),
('17:30'),
('18:00'),
('18:30'),
('19:00'),
('19:30'),
('20:00'),
('20:30'),
('21:00'),
('21:30'),
('22:00'),
('22:30'),
('23:00'),
('23:30');


CREATE TABLE rota(
employeeid INTEGER NOT NULL,
storeid INTEGER NOT NULL,
date VARCHAR(15) NOT NULL,
rotastartshift INTEGER NOT NULL,
rotaendshift INTEGER NOT NULL,
FOREIGN KEY(employeeid) REFERENCES employees(eid),
FOREIGN KEY(storeid) REFERENCES store(sid),
FOREIGN KEY(rotastartshift) REFERENCES startshift(startid),
FOREIGN KEY(rotaendshift) REFERENCES endshift(endid));
drop table rota;

INSERT INTO rota(employeeid,storeid,date,rotastartshift,rotaendshift)VALUES
(1,2,'11-11-2190',4,16);

INSERT INTO rota(employeeid,storeid,date,rotastartshift,rotaendshift)VALUES
(1,2,'11-04-2021',4,16);


SELECT e.efname AS 'First Name', e.elname AS 'Last Name', sh.starthour AS 'Start Of Shift', en.endhour AS 'End Of Shift', e.eskills AS 'Skills', st.sname AS 'Store' ,st.slocation AS 'Location',st.saddress AS 'Store Address' FROM rota AS r ,employees AS e ,store AS st, startshift AS sh, endshift AS en WHERE e.eid=r.employeeid AND r.storeid = st.sid AND sh.startid = r.rotastartshift AND en.endid = r.rotaendshift;


CREATE TABLE availability(
avail INTEGER PRIMARY KEY AUTOINCREMENT,
empid INTEGER NOT NULL,
dayname VARCHAR NOT NULL,
stshid INTEGER NOT NULL,
enshid INTEGER NOT NULL,
reason VARCHAR(400),
FOREIGN KEY (empid) REFERENCES employees(eid),
FOREIGN KEY (stoshid) REFERENCES startshift(startid),
FOREIGN KEY (enshid) REFERENCES endshift(endid));
/*drop table availability;*/

INSERT INTO availability(empid,dayname,stsh,enshid,reason)VALUES
(" & a & ",' & selday(cmbAvaDay.SelectedItem) & '," & seltime() & ,, & ",' & txtAvaReason.Text & ');
/*SELECT e.efname AS 'Firstname', e.elname AS 'Lastname', e.eskills AS 'Skills', a.dayname AS 'Day', sh.starthour AS 'Start of the Shift', a.reason AS 'Reason' FROM availability AS a, employees AS e, startshift AS sh, endshift AS en WHERE e.eid = a.empid  AND e.stshid = sh.startid AND e.enshid = en.endid ;*/

CREATE TABLE users(
uid INT PRIMARY KEY AUTOINCREMENT,
username VARCHAR(20));


CREATE TABLE roles(
rid INT PRIMARY KEY AUTOINCREMENT,
rolename VARCHAR(20));


CREATE TABLE useroles(
userid INT,
roleid INT,
FOREIGN KEY(userid) REFERENCES users(uid),
FOREIGN KEY(roleid) REFERENCES roles(rid));

SELECT * FROM rota AS r ,employees AS e ,store AS s WHERE e.eid=r.employeeid AND r.storeid = s.sid;

CREATE TABLE holidays(
holid INTEGER PRIMARY KEY AUTOINCREMENT,
holiemp INTEGER NOT NULL,
hreason VARCHAR(200),
holidayn INTEGER NOT NULL,
FOREIGN KEY (holiemp) REFERENCES employees(eid));




drop table holidays;


INSERT INTO holidays(holiemp,hreason,holidayn) VALUES
(1,'bathroom',30);


UPDATE holidaysbookings
SET daysbooked = daysbooked - 3
WHERE holiemp = 1;


SELECT * FROM holidays;


drop table holidaysbookings;


SELECT e.efname AS 'First Name', e.elname AS 'Last Name', e.eskills AS 'Skills', hb.hnumber AS 'Holidays Remaining', h.hreason AS 'Reason' , e.pnum AS 'Phone Number' FROM holidays AS h, employees AS e, holidaysbookings AS hb 
WHERE e.eid=h.holiemp AND h.holidayn = hb.holiday
ORDER BY hb.hnumber ASC;




CREATE TABLE login(
username VARCHAR(20) PRIMARY KEY,
password VARCHAR(100) NOT NULL);