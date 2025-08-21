Public Class Maps
    Public Shared Function WardChargeNurse(ward As Ward, charge_nurse As Staff) As Ward
        ward.charge_nurse = charge_nurse
        Return ward
    End Function

    Public Shared Function StaffQualification(staff As Staff, qualification As StaffQualification) As StaffQualification
        qualification.staff = staff
        Return qualification
    End Function

    Public Shared Function StaffWorkExp(staff As Staff, workExp As StaffWorkExperience) As StaffWorkExperience
        workExp.staff = staff
        Return workExp
    End Function
End Class
