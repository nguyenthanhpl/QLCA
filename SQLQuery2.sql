select * from PhongBan

select * from NhanVien

select * from Roles

delete from Roles


DBCC CHECKIDENT ('NhanVien', RESEED, 0);
GO

insert into Roles(URole)
values
('Admin'),
('User')

update NhanVien
set IDRole = '1'
where ID = '15'
