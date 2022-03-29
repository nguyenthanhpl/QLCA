use QuanLiCaAn
go


select * from Roles

update Roles
set URole = N'User'
where IDUser='12'


update Roles
set URole = N'User'
where IDUser='13'


update Roles
set URole = N'User'
where IDUser='14'


update Roles
set URole = N'User'
where IDUser='15'

alter table NhanVien
add IDRole int

select * from NhanVien

update NhanVien
set IDRole = '2'
where ID = '11'


update NhanVien
set IDRole = '3'
where ID = '12'

update NhanVien
set IDRole = '4'
where ID = '13'

update NhanVien
set IDRole = '5'
where ID = '14'


update NhanVien
set IDRole = '6'
where ID = '15'